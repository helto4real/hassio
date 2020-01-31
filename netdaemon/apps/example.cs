using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     Example app
/// </summary>
public class ExampleApp : NetDaemonApp
{
    public override async Task InitializeAsync()
    {
        Entity("binary_sensor.kitchen_pir")
        .WhenStateChange(to: "on")
            .UseEntity("light.kitchen_light")
                .TurnOn()
        .Execute();

        Entity("binary_sensor.kitchen_pir")
        .WhenStateChange(to: "off")
            .AndNotChangeFor(TimeSpan.FromMinutes(10))
            .UseEntity("light.kitchen_light")
                .TurnOff()
        .Execute();

    }
}