using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;



/// <summary>
///     App docs
/// </summary>
public class HouseStateManager : NetDaemonApp
{
    #region -- Config properties --
    public string? WeekdayNight { get; set; }
    public string? WeekendNight { get; set; }
    public string? DayTime { get; set; }
    public double? ElevationEvening { get; set; }
    public double? ElevationMorning { get; set; }

    public string? HouseStateInputSelect { get; set; }
    #endregion

    public bool IsCloudy => GetState("sensor.yr_cloudiness")?.State > 90.0;
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
        // Make dummy scenes set house state
        ListenServiceCall("scene", "turn_on", async (data) =>
        {
            var sceneEntityId = (string?)data?.entity_id;

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
                await SetHouseState(houseState);
        });
    }

    private void InitDayTime()
    {
        Log($"Setting daytime: {DayTime}");
        Scheduler.RunDaily(DayTime!, async () => await SetHouseState(HouseState.Day));
    }

    /// <summary>
    ///     Every weekday set night time on configured time (WeekdayNight)
    /// </summary>
    private void InitNightTimeOnWeekdays()
    {
        Log($"Setting weekday night time: {WeekdayNight}");
        Scheduler.RunDaily(WeekdayNight!, new DayOfWeek[]
        {
            DayOfWeek.Sunday,
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
        }
        , async () => await SetHouseState(HouseState.Night));
    }

    /// <summary>
    ///     Every weekend set night time on configured time (WeekendNight)
    /// </summary>
    private void InitNightTimeOnWeekends()
    {
        Log($"Setting weekend night time: {WeekendNight}");
        Scheduler.RunDaily(WeekendNight!, new DayOfWeek[]
        {
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
        }
        , async () => await SetHouseState(HouseState.Night));
    }

    /// <summary>
    ///     When elevation <= 9 and sun is not rising and depending if
    ///     it is cloudy set the evening state
    /// </summary>
    private void InitEveningSchedule()
    {
        // when elevation <9 and counting cloudiness set evening state
        Entity("sun.sun")
            .WhenStateChange((n, o) =>
                n?.Attribute?.elevation <= ElevationEvening &&
                n?.Attribute?.rising == false &&
                o?.Attribute?.elevation > ElevationEvening)
                    .Call(async (entityId, newState, oldState) =>
                    {
                        // If not cloudy, set evening else wait 45 minutes
                        if (IsCloudy)
                        {
                            await SetHouseState(HouseState.Evening);
                            Log($"It is evening {DateTime.Now}");
                        }
                        else
                        {
                            Log($"It is evening {DateTime.Now} not cloudy set evening in 45 minuts!");
                            Scheduler.RunIn(TimeSpan.FromMinutes(45),
                                async () => await SetHouseState(HouseState.Evening));
                        }
                    }).Execute();
    }

    /// <summary>
    ///     When elevation <= 9 and sun is not rising and depending if
    ///     it is cloudy set the evening state
    /// </summary>
    private void InitMorningSchedule()
    {
        // when elevation <9 and counting cloudiness set evening state
        Entity("sun.sun")
            .WhenStateChange((n, o) =>
                n?.Attribute?.elevation >= ElevationMorning &&
                n?.Attribute?.rising == true &&
                o?.Attribute?.elevation < ElevationMorning)
                    .Call(async (entityId, newState, oldState) =>
                    {
                        // If not cloudy, set evening else wait 45 minutes
                        if (!IsCloudy)
                        {
                            await SetHouseState(HouseState.Morning);
                            Log($"It is evening {DateTime.Now}");
                        }
                        else
                        {
                            Log($"It is evening {DateTime.Now} not cloudy set evening in 45 minuts!");
                            Scheduler.RunIn(TimeSpan.FromMinutes(45),
                                async () => await SetHouseState(HouseState.Morning));
                        }
                    }).Execute();
    }

    /// <summary>
    ///     Converts House State to real state in Home Assistant
    /// </summary>
    /// <param name="state">State to set</param>
    private async Task SetHouseState(HouseState state)
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
        var currentState = GetState(HouseStateInputSelect!);
        if (currentState?.State != select_state)
        {
            await this.InputSelectSetOption(HouseStateInputSelect!, select_state);
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