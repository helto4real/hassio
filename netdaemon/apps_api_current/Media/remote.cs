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
        Events(n => n.EventId == "deconz_event" && n.Data?.id == "tvrum_cube")
            .Call(async (ev, data) =>
                {
                    if (data?.gesture == null)
                        return; // Should have some logging here dooh

                    double gesture = data?.gesture;

                    switch (gesture)
                    {
                        case 1:         // Shake
                            await Entity(RemoteTVRummet).Toggle().ExecuteAsync();
                            break;
                        case 3:         // Flip
                            await PlayPauseMedia();
                            break;
                        case 7:         // Turn clockwise
                            await VolumeUp();
                            break;
                        case 8:         // Turn counter clockwise
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
        await CallServiceAsync("remote", "send_command", new
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
        await CallServiceAsync("remote", "send_command", new
        {
            entity_id = RemoteTVRummet,
            device = MaranzDeviceId,
            command = "VolumeDown",
            num_repeats = 10,
            delay_secs = 0.01
        });
    }

}
