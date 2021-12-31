using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

/// <summary>
///     Manage remote control using a xiaomi magic cube.
///     Following use-cases are implemented
///     - Shake, Turns on / Turns off TV
///     - Turn clockwise, volume up
///     - Turn counter clockwise, volume down
///     - Flip, pause/play
/// </summary>
public class MagicCubeRemoteControlManager : NetDaemonRxApp
{
    #region -- Config properties --

    public string? RemoteTVRummet { get; set; }
    public int? MaranzDeviceId { get; set; }
    public IEnumerable<string>? TvMediaPlayers { get; set; }

    #endregion
    public override void Initialize()
    {
        // 00:15:8d:00:02:69:e8:63
        Entity("sensor.tvrum_cube")
            .StateChanges
            // .Where(
            //     e => e.Event == "deconz_event" &&
            //          e.Data?.id == "tvrum_cube")
            .Subscribe(s =>
            {
                // if (s.New is object)
                //     Log("CUBE: state: {state}\r\n   action:{action}\r\n   side: {side}\r\n   angle: {angle}", 
                //         s.New?.State,
                //         s.New?.Attribute?.action,
                //         s.New?.Attribute?.side,
                //         s.New?.Attribute?.angle);
                if (s.New?.State is null)
                     return;

                switch (s.New?.State)
                {
                    case "shake":         // Shake
                        Entity(RemoteTVRummet!).Toggle();
                        break;
                    case "flip90":         // Flip
                        PlayPauseMedia();
                        break;
                    case "rotate_right":         // Turn clockwise
                        VolumeUp();
                        break;
                    case "rotate_left":         // Turn counter clockwise
                        VolumeDown();
                        break;
                }
            }
            );
    }

    /// <summary>
    ///     Pauses any media playing, play any paused media connected to TV
    /// </summary>
    private void PlayPauseMedia()
    {
        foreach (var player in TvMediaPlayers!)
        {
            var playerState = State(player)?.State;
            if (playerState == "playing")
                CallService("media_player", "media_pause", new { entity_id = player });
            else if (playerState == "paused")
                CallService("media_player", "media_play", new { entity_id = player });
        }
    }

    /// <summary>
    ///     Turn volume up on Maranz receiver
    /// </summary>
    private void VolumeUp()
    {
        CallService("remote", "send_command", new
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
    private void VolumeDown()
    {
        CallService("remote", "send_command", new
        {
            entity_id = RemoteTVRummet,
            device = MaranzDeviceId,
            command = "VolumeDown",
            num_repeats = 10,
            delay_secs = 0.01
        });
    }

}
