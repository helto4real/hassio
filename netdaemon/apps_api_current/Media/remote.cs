using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     Manage remote control using a xiaomi magic cube.
///     Following use-cases are implemented
///     - Shake, Turns on / Turns off TV
///     - Turn clockwise, volume up
///     - Turn counter clockwise, volume down
///     - Flip, pause/play
/// </summary>
public class MagicCubeRemoteControlManager : NetDaemonApp
{
    #region -- Config properties --

    public string? RemoteTVRummet { get; set; }
    public int? MaranzDeviceId { get; set; }
    public IEnumerable<string>? TvMediaPlayers { get; set; }

    #endregion
    public override Task InitializeAsync()
    {
        // 00:15:8d:00:02:69:e8:63
        Events(n => n.EventId == "zha_event" && n.Data?.device_ieee == "00:15:8d:00:02:69:e8:63")
            .Call(async (ev, data) =>
                {
                    if (data?.command == null)
                        return; // Should have some logging here dooh

                    string gesture = data?.command;

                    switch (gesture)
                    {
                        case "shake":         // Shake
                            await Entity(RemoteTVRummet).Toggle().ExecuteAsync();
                            break;
                        case "flip":         // Flip
                            await PlayPauseMedia();
                            break;
                        case "rotate_right":         // Turn clockwise
                            await VolumeUp();
                            break;
                        case "rotate_left":         // Turn counter clockwise
                            await VolumeDown();
                            break;
                    }

                })
            .Execute();

        // No async calls so just return completed task
        return Task.CompletedTask;
    }

    /// <summary>
    ///     Pauses any media playing, play any paused media connected to TV
    /// </summary>
    private async Task PlayPauseMedia()
    {
        foreach (var player in TvMediaPlayers)
        {
            var playerState = GetState(player)?.State;
            if (playerState == "playing")
                await MediaPlayer(player).Pause().ExecuteAsync();
            else if (playerState == "paused")
                await MediaPlayer(player).Play().ExecuteAsync();
        }
    }

    /// <summary>
    ///     Turn volume up on Maranz receiver
    /// </summary>
    private async Task VolumeUp()
    {
        await CallService("remote", "send_command", new
        {
            entity_id = RemoteTVRummet,
            device = MaranzDeviceId,
            command = "VolumeUp",
            num_repeats = 10,
            delay_secs = 0.01
        });
    }

    /// <summary>
    ///     Turn volume down on Maranz receiver
    /// </summary>
    private async Task VolumeDown()
    {
        await CallService("remote", "send_command", new
        {
            entity_id = RemoteTVRummet,
            device = MaranzDeviceId,
            command = "VolumeDown",
            num_repeats = 10,
            delay_secs = 0.01
        });
    }

}
