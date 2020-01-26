using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;
public class LightManager : NetDaemonApp
{
    public override Task InitializeAsync()
    {
        return Task.CompletedTask;
        //     Log("Initializing app MyApp");
        //     Entity("binary_sensor.kok_pir")
        //         .WhenStateChange(to: "on", from: "off")
        //             .UseEntity("light.kok_fonster")
        //                 .TurnOn()
        //                     .WithAttribute("transition", 0)
        //     .Execute();

        //     Entity("binary_sensor.kok_pir")
        //         .WhenStateChange(to: "off", from: "on")
        //             .AndNotChangeFor(TimeSpan.FromSeconds(60))
        //         .UseEntity("light.kok_fonster")
        //             .TurnOff()
        //                 .WithAttribute("transition", 0)
        //     .Execute();
    }
}


