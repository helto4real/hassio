using System;
using System.Linq;
using System.Reactive.Linq;
using NetDaemon.Common;
using NetDaemon.HassModel.Common;
using NetDaemon.HassModel.Extensions;
using NetDaemon.HassModel.Entities;
using NetDaemon.Extensions.Scheduler;
using HomeAssistantGenerated;
using Microsoft.Extensions.Logging;

/// <summary>
///     Room specific automations.
/// </summary>
[NetDaemonApp]
public class RoomSpecificManager
{
    private readonly Entities _entities;
    private readonly INetDaemonScheduler _scheduler;
    private readonly IHaContext _ha;

    public RoomSpecificManager(IHaContext ha, INetDaemonScheduler scheduler)
    {
        _entities = new Entities(ha);
        _scheduler = scheduler;
        _ha = ha;

        SetupTomasComputerAutoStart();
        SetupManageMelkersChromecast();
        SetupTurnOffKidsLightsEarly();
    }
    private void SetupTurnOffKidsLightsEarly()
    {
        _scheduler.RunDaily(TimeSpan.Parse("22:00:00"), () => TurnOffKidsLight());
    }

    private void TurnOffKidsLight()
    {
        _ha.TurnOff("light.melkers_rum", "light.sallys_rum");
    }
    private void SetupManageMelkersChromecast()
    {
        _scheduler.RunDaily(TimeSpan.Parse("01:30:00"), () =>
            {
                // Every night reset Melkers chromecast so the TV will auto shut off
                _entities.Switch.Switch8MelkersTv.TurnOff();
                _scheduler.RunIn(TimeSpan.FromMinutes(5), () => _entities.Switch.Switch8MelkersTv.TurnOn());
            });
    }

    public bool TomasIsHome => _entities.DeviceTracker.TomasPresence.State == "Hemma";

    private void SetupTomasComputerAutoStart()
    {
        // Turn on computer if Tomas is home and enter room
        _entities.BinarySensor.TomasRumPir
            .StateChanges()
            .Where(e =>
                e.New.IsOn() &&
                _entities.Switch.ComputerTomas.IsOff() &&
                TomasIsHome)
            .Subscribe(
                s => _entities.Switch.ComputerTomas.TurnOn());

        // Turn off computer if no movement for one hour en Tomas room
        _entities.BinarySensor.TomasRumPir
            .StateChanges()
            .Where(e => e.New.IsOff())
            .Throttle(TimeSpan.FromHours(1))
            .Subscribe(s => _entities.Switch.ComputerTomas.TurnOff());
    }
}