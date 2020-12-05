using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using System.Threading;

/// <summary>
///     Following use-case is implemented
///     - If no one is home and motion is detected, notify the discord channel
/// </summary>


public class CameraMotionApp : NetDaemonRxApp
{
    /// <summary>
    ///     The cameras being managed, se yaml file
    /// </summary>
    public IEnumerable<string>? Cameras { get; set; }

    public override Task InitializeAsync()
    {
        Entity("binary_sensor.kamera_3_motion_detected")
            .StateChanges
            .Where(e => e.New.State == "on")
            .Where(e => DateTime.Now.Hour > 8 && DateTime.Now.Hour < 23)
            .Delay(TimeSpan.FromSeconds(1)) // Delay one second before snapshot to get better pictures
            .Subscribe(s =>
            {
                this.CameraTakeSnapshotAndNotify("camera.kamera_3");
            });

        return Task.CompletedTask;
    }
}