using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public class RoomSpecificManager : NetDaemonApp
{
    public IEnumerable<string>? KidsLights { get; set; }

    public override Task InitializeAsync()
    {
        SetupTomasComputerAutoStart();
        SetupManageMelkersChromecast();
        SetupTurnOffKidsLightsEarly();

        return Task.CompletedTask;
    }

    private void SetupTurnOffKidsLightsEarly()
    {
        Scheduler.RunDaily("22:00:00", () =>
            Entities(KidsLights!).TurnOff().ExecuteAsync());
    }

    private void SetupManageMelkersChromecast()
    {
        // Every night reset Melkers chromecast so the TV will auto shut off
        Scheduler.RunDaily("01:30:00", async () =>
        {
            await Entity("switch.switch8_melkers_tv")
                .TurnOff().ExecuteAsync();

            Scheduler.RunIn(TimeSpan.FromMinutes(5), async () =>
                await Entity("switch.switch8_melkers_tv").TurnOn().ExecuteAsync());
        });
    }

    public bool TomasIsHome => GetState("device_tracker.tomas_presence")?.State == "Hemma";
    private void SetupTomasComputerAutoStart()
    {
        // Turn on computer if Tomas is home and enter room
        Entity("binary_sensor.tomas_rum_pir")
            .WhenStateChange((n, o) =>
                n?.State == "on" &&
                o?.State != n?.State &&
                TomasIsHome)
            .UseEntity("switch.computer_tomas")
                .TurnOn().Execute();

        // Turn off computer if no movement for one hour en Tomas room
        Entity("binary_sensor.tomas_rum_pir")
            .WhenStateChange(to: "off")
                .AndNotChangeFor(TimeSpan.FromHours(1))
            .UseEntity("switch.computer_tomas")
                .TurnOff().Execute();
    }
}