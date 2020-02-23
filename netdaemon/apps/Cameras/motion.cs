using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

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

    public override async Task InitializeAsync()
    {
        var state = Storage.SomeSavedState ?? 0;
        state += 1;

        Storage.SomeSavedState = state;

        Log($"Saved state is {Storage.SomeSavedState}");
        // Todo: add motion logic, this just takes snapshot at startup for test
        // foreach (var camera in Cameras!)
        // {
        //     await this.CameraTakeSnapshotAndNotify(camera);
        // }
    }
}