using System;
using System.Linq;
using System.Reactive.Linq;
using NetDaemon.Common;
using NetDaemon.HassModel.Common;
using NetDaemon.HassModel.Entities;
using NetDaemon.Extensions.Scheduler;
using HomeAssistantGenerated;
using Microsoft.Extensions.Logging;

/// <summary>
///     Manage state of morning, house, day, evening, night and cleaning
/// </summary>
[NetDaemonApp]
// [Focus]
public class HouseStateManager
{
    private readonly TimeSpan NIGHTTIME_WEEKDAYS = TimeSpan.Parse("11:30:00");
    private readonly TimeSpan NIGHTTIME_WEEKENDS = TimeSpan.Parse("11:30:00");
    private readonly TimeSpan DAYTIME = TimeSpan.Parse("09:00:00");
    private readonly Entities _entities;
    private readonly INetDaemonScheduler _scheduler;
    private readonly ILogger<HouseStateManager> _log;

    #region DayOfWeekConfig
    private readonly DayOfWeek[] WeekdayNightDays = new DayOfWeek[]
        {
            DayOfWeek.Sunday,
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
        };

    private readonly DayOfWeek[] WeekendNightDays = new DayOfWeek[]
        {
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
        };

    #endregion

    public bool IsDaytime => _entities.InputSelect.HouseModeSelect.State == "Dag";
    public bool IsNighttime => _entities.InputSelect.HouseModeSelect.State == "Natt";

    public HouseStateManager(IHaContext ha, INetDaemonScheduler scheduler, ILogger<HouseStateManager> logger)
    {
        _entities = new Entities(ha);
        _scheduler = scheduler;
        _log = logger;

        SetDayTime();
        SetEveningWhenLowLightLevel();
        SetNightTime();
        SetMorningWhenBrightLightLevel();
        InitHouseStateSceneManagement();
    }


    /// <summary>
    ///     Sets the house state on the corresponding scene
    /// </summary>
    private void InitHouseStateSceneManagement()
    {
        _entities.Scene.Dag.WhenTurnsOn(s => SetHouseState(HouseState.Day));
        _entities.Scene.Kvall.WhenTurnsOn(s => SetHouseState(HouseState.Evening));
        _entities.Scene.Natt.WhenTurnsOn(s => SetHouseState(HouseState.Night));
        _entities.Scene.Morgon.WhenTurnsOn(s => SetHouseState(HouseState.Morning));
        _entities.Scene.Stadning.WhenTurnsOn(s => SetHouseState(HouseState.Cleaning));
    }

    private void SetDayTime()
    {
        _log.LogInformation($"Setting daytime: {DAYTIME}");
        _scheduler.RunDaily(DAYTIME, () => SetHouseState(HouseState.Day));
    }

    /// <summary>
    ///     Set night time schedule on different time different weekdays
    /// </summary>
    private void SetNightTime()
    {
        _log.LogInformation($"Setting weekday night time to: {NIGHTTIME_WEEKDAYS}");
        _scheduler.RunDaily(NIGHTTIME_WEEKDAYS, () =>
        {
            if (WeekdayNightDays.Contains(DateTime.Now.DayOfWeek))
                SetHouseState(HouseState.Night);
        });

        _log.LogInformation($"Setting weekend night time to: {NIGHTTIME_WEEKENDS}");

        _scheduler.RunDaily(NIGHTTIME_WEEKENDS, () =>
        {
            if (WeekendNightDays.Contains(DateTime.Now.DayOfWeek))
                SetHouseState(HouseState.Night);
        });
    }

    /// <summary>
    ///     Set to evening when the light level is low and it is daytime
    /// </summary>
    private void SetEveningWhenLowLightLevel()
    {
        _entities.Sensor.LightOutside
            .StateChanges
            .Where(e => _entities.Sensor.LightOutside.AsNumeric().State <= 25.0 && IsDaytime)
            .Subscribe(s => SetHouseState(HouseState.Evening));
    }

    /// <summary>
    ///     When the light levels are bright enough it is considered morning time
    /// </summary>
    private void SetMorningWhenBrightLightLevel()
    {
        _entities.Sensor.LightOutside
            .StateChanges
            .Where(e => _entities.Sensor.LightOutside.AsNumeric().State >= 30.0 &&
                        DateTime.Now.Hour > 5 && DateTime.Now.Hour < 10 &&
                        IsNighttime
            )
            .Subscribe(_ => SetHouseState(HouseState.Morning));
    }

    /// <summary>
    ///     Sets the house state to specified state and updates Home Assistant InputSelect
    /// </summary>
    /// <param name="state">State to set</param>
    private void SetHouseState(HouseState state)
    {
        _log.LogInformation($"Setting current house state to {state}", state);
        var select_state = state switch
        {
            HouseState.Morning => "Morgon",
            HouseState.Day => "Dag",
            HouseState.Evening => "Kväll",
            HouseState.Night => "Natt",
            HouseState.Cleaning => "Städning",
            _ => throw new ArgumentException("Not supported", nameof(state))
        };
        _entities.InputSelect.HouseModeSelect.SelectOption(option: select_state);
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
