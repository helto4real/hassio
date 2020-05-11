using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using JoySoftware.HomeAssistant.NetDaemon.Common.Reactive;
using System.Text.RegularExpressions;


/// <summary>
///     App docs
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

    public bool IsCloudy => State("sensor.yr_cloudiness")?.State > 90.0;
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
        RunDaily(DayTime!).Subscribe(s => SetHouseState(HouseState.Day));
    }

    /// <summary>
    ///     Every weekday set night time on configured time (WeekdayNight)
    /// </summary>
    private void InitNightTimeOnWeekdays()
    {
        Log($"Setting weekday night time: {WeekdayNight}");
        RunDaily(WeekdayNight!)
            .Where(e => NormalNightDays.Contains(DateTime.Now.DayOfWeek))
            .Subscribe(s => SetHouseState(HouseState.Night));
    }

    /// <summary>
    ///     Every weekend set night time on configured time (WeekendNight)
    /// </summary>
    private void InitNightTimeOnWeekends()
    {
        Log($"Setting weekend night time: {WeekendNight}");

        RunDaily(WeekdayNight!)
            .Where(e => LateNightDays.Contains(DateTime.Now.DayOfWeek))
            .Subscribe(s => SetHouseState(HouseState.Night));
    }

    /// <summary>
    ///     When elevation <= 9 and sun is not rising and depending if
    ///     it is cloudy set the evening state
    /// </summary>
    private void InitEveningSchedule()
    {
        // when elevation <9 and counting cloudiness set evening state
        Entity("sun.sun")
            .StateChanges
            .Where(e =>
                e.New?.Attribute?.elevation <= ElevationEvening &&
                e.New?.Attribute?.rising == false &&
                e.Old?.Attribute?.elevation > ElevationEvening)
            .Subscribe(s =>
            {
                // If not cloudy, set evening else wait 45 minutes
                if (IsCloudy)
                {
                    SetHouseState(HouseState.Evening);
                    Log($"It is evening {DateTime.Now}");
                }
                else
                {
                    Log($"It is evening {DateTime.Now} not cloudy set evening in 45 minuts!");
                    RunIn(TimeSpan.FromMinutes(45)).Subscribe(s => SetHouseState(HouseState.Evening));
                }
            });
    }

    /// <summary>
    ///     When elevation <= 9 and sun is not rising and depending if
    ///     it is cloudy set the evening state
    /// </summary>
    private void InitMorningSchedule()
    {
        // when elevation <9 and counting cloudiness set evening state
        Entity("sun.sun")
            .StateChanges
            .Where(e =>
                e.New?.Attribute?.elevation >= ElevationEvening &&
                e.New?.Attribute?.rising == true &&
                e.Old?.Attribute?.elevation < ElevationEvening)
            .Subscribe(s =>
                    {
                        // If not cloudy, set evening else wait 45 minutes
                        if (!IsCloudy)
                        {
                            SetHouseState(HouseState.Morning);
                            Log($"It is evening {DateTime.Now}");
                        }
                        else
                        {
                            Log($"It is evening {DateTime.Now} not cloudy set evening in 45 minuts!");
                            RunIn(TimeSpan.FromMinutes(45)).Subscribe(s => SetHouseState(HouseState.Morning));
                        }
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