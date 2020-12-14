using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using System.Text.RegularExpressions;


/// <summary>
///     Manage state of morning, house, day, evening, night and cleaning
/// </summary>
public class HouseStateManager : NetDaemonRxApp
{
    #region -- Config properties --
    public string? WeekdayNight { get; set; }
    public string? WeekendNight { get; set; }
    public string? DayTime { get; set; }
    public double? ElevationEvening { get; set; }
    public double? ElevationMorning { get; set; }

    public string? HouseStateInputSelect { get; set; }

    private DayOfWeek[] NormalNightDays = new DayOfWeek[]
        {
            DayOfWeek.Sunday,
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
        };

    private DayOfWeek[] LateNightDays = new DayOfWeek[]
        {
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
        };

    #endregion

    public bool IsCloudy => State("weather.smhi_hemma")?.Attribute?.cloudiness > 90.0;
    public override Task InitializeAsync()
    {
        InitDayTime();
        InitEveningSchedule();
        InitNightTimeOnWeekdays();
        InitNightTimeOnWeekends();
        InitMorningSchedule();
        InitHouseStateSceneManagement();

        return Task.CompletedTask;
    }

    private void InitHouseStateSceneManagement()
    {
        EventChanges
            .Where(e => e.Domain == "scene" && e.Event == "turn_on")
            .Subscribe(e =>
            {
                var sceneEntityId = (string?)e.Data?.entity_id;

                var houseState = sceneEntityId switch
                {
                    "scene.dag" => HouseState.Day,
                    "scene.kvall" => HouseState.Evening,
                    "scene.natt" => HouseState.Night,
                    "scene.morgon" => HouseState.Morning,
                    "scene.stadning" => HouseState.Cleaning,
                    _ => HouseState.Unknown
                };

                if (houseState != HouseState.Unknown)
                    SetHouseState(houseState);
            });

    }

    private void InitDayTime()
    {
        Log($"Setting daytime: {DayTime}");
        RunDaily(DayTime!, () => SetHouseState(HouseState.Day));
    }

    /// <summary>
    ///     Every weekday set night time on configured time (WeekdayNight)
    /// </summary>
    private void InitNightTimeOnWeekdays()
    {
        Log($"Setting weekday night time: {WeekdayNight}");
        RunDaily(WeekdayNight!, () =>
        {
            if (NormalNightDays.Contains(DateTime.Now.DayOfWeek))
                SetHouseState(HouseState.Night);
        });

    }

    /// <summary>
    ///     Every weekend set night time on configured time (WeekendNight)
    /// </summary>
    private void InitNightTimeOnWeekends()
    {
        Log($"Setting weekend night time: {WeekendNight}");

        RunDaily(WeekdayNight!, () =>
        {
            if (LateNightDays.Contains(DateTime.Now.DayOfWeek))
                SetHouseState(HouseState.Night);
        });
    }

    /// <summary>
    ///     When elevation <= 9 and sun is not rising and depending if
    ///     it is cloudy set the evening state
    /// </summary>
    private void InitEveningSchedule()
    {
        // Entity("sensor.light_outside")
        //     .StateChanges
        //     .Subscribe(s => Log("Light sensor value {state}, type: {type}, housestate: {housestate}", s.New?.State, s.New?.State.GetType().Name, State(HouseStateInputSelect!)?.State));

        Entity("sensor.light_outside")
            .StateChanges
            .Where(e =>
                (
                    (e.New?.State is double && e.New.State <= 20.0 ||
                    e.New?.State is long && e.New.State <= 20) &&
                    (e.Old?.State is double && e.Old.State > 20.0 ||
                    e.Old?.State is long && e.Old.State > 20) 
                ) &&
                State(HouseStateInputSelect!)?.State == "Dag"
            )
            .Throttle(TimeSpan.FromMinutes(20))
            .Subscribe(s =>
            {
                SetHouseState(HouseState.Evening);
                Log($"It is evening {DateTime.Now}");
            });
    }

    /// <summary>
    ///     When elevation <= 9 and sun is not rising and depending if
    ///     it is cloudy set the evening state
    /// </summary>
    private void InitMorningSchedule()
    {
        // when elevation <9 and counting cloudiness set evening state
        Entity("sensor.light_outside")
            .StateChanges
            .Where(e =>
                (
                    (e.New?.State is double && e.New.State >= 25.0 ||
                    e.New?.State is long && e.New.State >= 25) &&
                    (e.Old?.State is double && e.Old.State < 25.0 ||
                    e.Old?.State is long && e.Old.State < 25)
                ) &&
                State(HouseStateInputSelect!)?.State == "Natt"
            )
            .Throttle(TimeSpan.FromMinutes(20))
            .Subscribe(s =>
                    {
                        SetHouseState(HouseState.Morning);
                        Log($"It is morning {DateTime.Now}");
                    });
    }

    /// <summary>
    ///     Converts House State to real state in Home Assistant
    /// </summary>
    /// <param name="state">State to set</param>
    private void SetHouseState(HouseState state)
    {
        var select_state = state switch
        {
            HouseState.Morning => "Morgon",
            HouseState.Day => "Dag",
            HouseState.Evening => "Kväll",
            HouseState.Night => "Natt",
            HouseState.Cleaning => "Städning",
            _ => throw new ArgumentException("Not supported", nameof(state))
        };
        Log($"Setting housestate: {select_state} to {HouseStateInputSelect}");
        // Get the state now
        var currentState = State(HouseStateInputSelect!);
        if (currentState?.State != select_state)
        {
            CallService("input_select", "select_option", new { entity_id = HouseStateInputSelect!, option = select_state });
        }
    }
}

public enum HouseState
{
    Morning,
    Day,
    Evening,
    Night,
    Cleaning,
    Unknown
}
