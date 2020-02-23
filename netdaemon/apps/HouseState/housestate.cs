using System;
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
    public double? Elevation { get; set; }

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

        return Task.CompletedTask;
    }

    private void InitDayTime()
    {
        Scheduler.RunDaily(DayTime!, () => SetHouseState(HouseState.Morning));
    }

    /// <summary>
    ///     Every weekday set night time on configured time (WeekdayNight)
    /// </summary>
    private void InitNightTimeOnWeekdays()
    {
        Scheduler.RunDaily(WeekdayNight!, new DayOfWeek[]
        {
            DayOfWeek.Sunday,
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
        }
        , () => SetHouseState(HouseState.Night));
    }

    /// <summary>
    ///     Every weekend set night time on configured time (WeekendNight)
    /// </summary>
    private void InitNightTimeOnWeekends()
    {
        Scheduler.RunDaily(WeekendNight!, new DayOfWeek[]
        {
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
        }
        , () => SetHouseState(HouseState.Night));
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
                n?.Attribute?.elevation <= Elevation &&
                n?.Attribute?.rising == false &&
                o?.Attribute?.elevation > Elevation)
                    .Call(async (entityId, oldState, newState) =>
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
                            Scheduler.RunIn(TimeSpan.FromMinutes(5),
                                () => SetHouseState(HouseState.Evening));
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
                n?.Attribute?.elevation >= Elevation &&
                n?.Attribute?.rising == true &&
                o?.Attribute?.elevation < Elevation)
                    .Call(async (entityId, oldState, newState) =>
                    {
                        // If not cloudy, set evening else wait 45 minutes
                        if (!IsCloudy)
                        {
                            await SetHouseState(HouseState.Morning);
                            Log("It is evening {DateTime.Now}");
                        }
                        else
                        {
                            Log("It is evening {DateTime.Now} not cloudy set evening in 45 minuts!");
                            Scheduler.RunIn(TimeSpan.FromMinutes(45),
                                () => SetHouseState(HouseState.Morning));
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
            _ => throw new ArgumentException("Not supported", nameof(state))
        };
        await SetState(HouseStateInputSelect!, select_state);
    }

}

public enum HouseState
{
    Morning,
    Day,
    Evening,
    Night
}