using System;
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
    private readonly string _entityRemoteTVRummet = "remote.tvrummet";
    private readonly string _maranzDeviceId = "14329974"; //14329974
    private readonly string[] _tvMediaPlayers = {
        "media_player.tv_nere",
        "media_player.plex_kodi_add_on_libreelec" };
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
                            await Entity(_entityRemoteTVRummet).Toggle().ExecuteAsync();
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
        foreach (var player in _tvMediaPlayers)
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
        dynamic data = new FluentExpandoObject();
        await CallService("remote", "send_command", new
        {
            entity_id = _entityRemoteTVRummet,
            device = _maranzDeviceId,
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
            entity_id = _entityRemoteTVRummet,
            device = _maranzDeviceId,
            command = "VolumeDown",
            num_repeats = 10,
            delay_secs = 0.01
        });
    }

}
