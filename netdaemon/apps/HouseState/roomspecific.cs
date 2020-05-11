using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using JoySoftware.HomeAssistant.NetDaemon.Common.Reactive;

/// <summary>
///     App docs
/// </summary>
public class RoomSpecificManager : NetDaemonRxApp
{
    public IEnumerable<string>? KidsLights { get; set; }

    public override void Initialize()
    {
        SetupTomasComputerAutoStart();
        SetupManageMelkersChromecast();
        SetupTurnOffKidsLightsEarly();
    }

    private void SetupTurnOffKidsLightsEarly()
    {
        RunDaily("22:00:00")
            .Subscribe(s => Entities(KidsLights!).TurnOff());
    }

    private void SetupManageMelkersChromecast()
    {
        RunDaily("01:30:00")
            .Subscribe(s =>
            {
                // Every night reset Melkers chromecast so the TV will auto shut off
                Entity("switch.switch8_melkers_tv").TurnOff();
                RunIn(TimeSpan.FromMinutes(5)).Subscribe(s => Entity("switch.switch8_melkers_tv").TurnOn());
            });

    }

    public bool TomasIsHome => State("device_tracker.tomas_presence")?.State == "Hemma";
    private void SetupTomasComputerAutoStart()
    {
        // Turn on computer if Tomas is home and enter room
        Entity("binary_sensor.tomas_rum_pir")
            .StateChanges
            .Where(e =>
                e.New?.State == "on" &&
                TomasIsHome)
            .Subscribe(s => Entity("switch.computer_tomas").TurnOn());

        // Turn off computer if no movement for one hour en Tomas room
        Entity("binary_sensor.tomas_rum_pir")
            .StateChanges
            .Where(e => e.New.State == "off")
            .NDSameStateFor(TimeSpan.FromHours(1))
            .Subscribe(s => Entity("switch.computer_tomas").TurnOff());
    }
}