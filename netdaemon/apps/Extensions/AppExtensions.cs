using System.Collections.Generic;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;
public static class DaemonAppExtensions
{

    /// <summary>
    ///     Takes a snapshot of given entity id of camera and sends to private discord server
    /// </summary>
    /// <param name="app">NetDaemonApp to extend</param>
    /// <param name="camera">Unique id of the camera</param>
    public async static Task CameraTakeSnapshotAndNotify(this NetDaemonApp app, string camera)
    {
        var dict = new Dictionary<string, IEnumerable<string>>
        {
            ["images"] = new List<string> { $"/config/www/motion/{camera}_latest.jpg" }
        };

        await app.CallService("camera", "snapshot", new
        {
            entity_id = camera,
            filename = $"/config/www/motion/{camera}_latest.jpg"
        });

        await app.CallService("notify", "hass_discord", new
        {
            data = dict,
            message = $"{camera}",
            target = "511278310584746008"
        });
    }
}