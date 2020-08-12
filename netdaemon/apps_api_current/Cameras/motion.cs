using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDaemon.Common;

/// <summary>
///     Following use-case is implemented
///     - If no one is home and motion is detected, notify the discord channel
/// </summary>


public class CameraMotionApp : NetDaemonApp
{
    /// <summary>
    ///     The cameras being managed, se yaml file
    /// </summary>
    public IEnumerable<string>? Cameras { get; set; }

    public override Task InitializeAsync()
    {
        Entity("binary_sensor.kamera_3_motion_detected").WhenStateChange("on").Call(async (entityId, to, from) =>
        {
            if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 23)
            {
                await Task.Delay(1000); // Delay one secod before snapshot to get better pictures
                await this.CameraTakeSnapshotAndNotify("camera.kamera_3");
            }


        }).Execute();

        return Task.CompletedTask;
    }
}