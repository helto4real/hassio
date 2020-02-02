using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;
using System.Linq;
public class BatteryManager : NetDaemonApp
{
    public override Task InitializeAsync()
    {
        foreach (var device in State.Where(n => n.Attribute.battery_level < 20))
        {
            Log($"{device.EntityId} : {device.Attribute.battery_level}");
        }

        foreach (var device in State.Where(n => n.EntityId.Contains("battery_level") && n.State is long && n.State < 20))
        {
            // Remove 14 characters from end (battery_level) to get entity id
            Log($"{device.EntityId[0..^14]} : {device.State}");
        }

        // No async so just return completed task
        return Task.CompletedTask;
    }
}