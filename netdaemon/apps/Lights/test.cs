using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;
public class LightManager : NetDaemonApp
{
    public override async Task InitializeAsync()
    {
        Log("Initializing app MyApp");
        Entity("binary_sensor.kok_pir")
            .StateChanged(to: "on", from: "off")
                .Entity("light.kok_fonster").TurnOn()
                    .UsingAttribute("transition", 0)
        .Execute();

        Entity("binary_sensor.kok_pir")
            .StateChanged(to: "off", from: "on")
                .For(TimeSpan.FromSeconds(60))
            .Entity("light.kok_fonster").TurnOff()
                .UsingAttribute("transition", 0)
        .Execute();
    }
}


