using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;
using Helto4real.Powertools;
public static class DaemonAppExtensions
{

    /// <summary>
    ///     Takes a snapshot of given entity id of camera and sends to private discord server
    /// </summary>
    /// <param name="app">NetDaemonApp to extend</param>
    /// <param name="camera">Unique id of the camera</param>
    public async static Task CameraTakeSnapshotAndNotify(this NetDaemonApp app, string camera)
    {
        var imagePath = await app.CameraSnapshot(camera);

        await app.NotifyImage(camera, imagePath);
    }

    public async static Task Notify(this NetDaemonApp app, string message)
    {
        await app.CallService("notify", "hass_discord", new
        {
            message = message,
            target = "511278310584746008"
        });
    }

    public async static Task NotifyImage(this NetDaemonApp app, string message, string imagePath)
    {
        var dict = new Dictionary<string, IEnumerable<string>>
        {
            ["images"] = new List<string> { imagePath }
        };

        await app.CallService("notify", "hass_discord", new
        {
            data = dict,
            message = message,
            target = "511278310584746008"
        });
    }
}