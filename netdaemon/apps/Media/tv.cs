using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using Netdaemon.Generated.Reactive;
using NetDaemon.Common;
using System.Threading;

/// <summary>
///     Manage the media in the tv room
/// </summary>
/// <remarks>
///     Following use-cases are implemented
///         - Turn on TV and set scene when chromecast is playing and TV is off
///         - Turn off TV when nothing is playing for a time
///         - When remote activity changes, run correct scene (RunScript)
///
/// </remarks>
public class TVManager : NetDaemonRxApp
{
    // The Remote that controls the TV (Harmony Logitech)
    // private readonly string _entityRemoteTVRummet = "remote.tvrummet";

    // Media players connected to TV
    // private readonly string[] _entityMediaPlayers = {
    //     "media_player.tv_nere",
    //     "media_player.plex_kodi_add_on_libreelec" };

    #region -- Config properties --

    public string? RemoteTVRummet { get; set; }
    public IEnumerable<string>? TvMediaPlayers { get; set; }

    #endregion

    // 20 minutes idle before turn off TV
    private readonly TimeSpan _idleTimeout = TimeSpan.FromMinutes(20);

    // True if we are in the process of turning on the TV
    private bool _isTurningOnTV = false;
    // If this RunScript paused the mediaplayer, it is here
    private string? _currentlyPausedMediaPlayer;
    // The time when we stopped play media for any of the media players
    private DateTime? _timeStoppedPlaying = null;

    /// <summary>
    ///     Initialize, is automatically run by the daemon
    /// </summary>
    public override void Initialize()
    {
        // Set up the state management

        // When state change on my media players, call OnMediaStateChanged
        Entities(TvMediaPlayers!)
            .StateChanges
            .Subscribe(s => OnMediaStateChanged(s.New, s.Old));

        // When TV on (remote on), call OnTvTurnedOn
        Entity(RemoteTVRummet!)
            .StateChanges
            .Where(e =>
                e.Old?.State == "off" &&
                e.New?.State == "on")
            .Subscribe(s => OnTVTurnedOn());


        // When ever TV remote activity changes, ie TV, Film, Poweroff call OnTvActivityChange
        Entity(RemoteTVRummet!)
            .StateAllChanges
            .Where(e => e.New?.Attribute?.current_activity != e.Old?.Attribute?.current_activity)
            .Subscribe(s => OnTvActivityChange(s.New));

        // This function does not contain any async calls so just return completed task
        // return Task.CompletedTask;
    }

    /// <summary>
    ///     Returns true if TV is currently on
    /// </summary>
    public bool TvIsOn => State(RemoteTVRummet!)?.State == "on";

    /// <summary>
    ///     Returns true if any of the media players is playing
    /// </summary>
    /// <returns></returns>
    public bool MediaIsPlaying => TvMediaPlayers.Where(n => State(n)?.State == "playing").Count() > 0;

    /// <summary>
    ///     Called when ever state change for the media_players playing on the TV
    /// </summary>
    public void OnMediaStateChanged(EntityState to, EntityState from)
    {
        if (to?.State == "playing")
        {
            _timeStoppedPlaying = null;
            TurnOnTvIfOff(to.EntityId);
        }
        else
        {
            if (from?.State == "playing")
            {
                _timeStoppedPlaying = DateTime.Now;
                // Check in 20 minutes if TV is on and nothing still playing
                RunIn(_idleTimeout,
                    () =>
                    {
                        if (TvIsOn && !MediaIsPlaying && _timeStoppedPlaying != null)
                        {
                            if (DateTime.Now.Subtract(_timeStoppedPlaying.Value) >= _idleTimeout)
                            {
                                // Idle timeout went by without any change in state turn off TV
                                Log($"TV been idle for {_idleTimeout} minutes, turning off");
                                RunScript("tv_off_scene");
                            }
                            // If the state did has changed after we waited just run to completion
                        }
                    });
            }
        }
    }

    /// <summary>
    ///     Turns the TV on if not on and pauses any playing media until TV is fully on
    /// </summary>
    private void TurnOnTvIfOff(string entityId)
    {
        if (!TvIsOn && !_isTurningOnTV)
        {
            // Tv is of and there are not an operation turning it on
            _isTurningOnTV = true;
            Log($"TV is not on, pause media {entityId} and turn on tv!");

            // Tv and light etc is managed through a RunScript
            RunScript("tv_scene");
        }
        if (_isTurningOnTV) // Always pause media if TV is turning on
        {
            _currentlyPausedMediaPlayer = entityId;
            CallService("media_player", "media_pause", new { entity_id = entityId });
        }
    }

    /// <summary>
    ///     When TV is on and we have paused media, play it
    /// </summary>
    public void OnTVTurnedOn()
    {
        if (_isTurningOnTV && !string.IsNullOrEmpty(_currentlyPausedMediaPlayer))
        {
            // We had just turned on tv with this RunScript and have a media player paused
            // First delay and wait for the TV to get ready
            Thread.Sleep(9000);
            CallService("media_player", "media_play", new { entity_id = _currentlyPausedMediaPlayer });
        }
        _isTurningOnTV = false;
    }

    /// <summary>
    ///     When TV is activity changes, ie TV, Film or PowerOff.!--
    ///     This is to manage manual remote activities
    /// </summary>
    public void OnTvActivityChange(EntityState to)
    {
        switch (to?.Attribute?.current_activity)
        {
            case "TV":
                RunScript("tv_scene");
                break;
            case "Film":
                RunScript("film_scene");
                break;
            case "PowerOff":
                RunScript("tv_off_scene");
                Entities(TvMediaPlayers!).TurnOff();
                Light.Tvrummet.TurnOn(new { transition = 0 });
                break;
        }
    }

}