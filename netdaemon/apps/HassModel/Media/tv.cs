//
using System.Threading;
/// <summary>
///     Manage the media in the tv room
///     Following use-cases are implemented
///         - Turn on TV and set scene when chromecast is playing and TV is off
///         - Turn off TV when nothing is playing for a time
///         - When remote activity changes, run correct scene (RunScript)
/// </summary>
[NetDaemonApp]
public class TVManager
{
    private readonly IHaContext _ha;
    private readonly Entities _entities;
    private readonly Services _services;
    private readonly ILogger<TVManager> _log;
    private readonly INetDaemonScheduler _scheduler;
    public TVManager(IHaContext ha, ILogger<TVManager> logger, INetDaemonScheduler scheduler)
    {
        _ha = ha;
        _entities = new Entities(ha);
        _services = new Services(ha);
        _log = logger;
        _scheduler = scheduler;

        _entities.MediaPlayer.ShieldTv
            .StateChanges()
            .Subscribe(s =>
            {
                OnMediaStateChanged(s.New, s.Old);
            });

        // When TV on (remote on), call OnTvTurnedOn
        _entities.Remote.Tvrummet
            .StateChanges()
            .Where(e =>
                e.Old.IsOff() &&
                e.New.IsOn())
            .Subscribe(s =>
            {
                OnTVTurnedOn();
            });


        // When ever TV remote activity changes, ie TV, Film, Poweroff call OnTvActivityChange
        _entities.Remote.Tvrummet
            .StateAllChanges()
            .Where(e => e.New?.Attributes?.CurrentActivity != e.Old?.Attributes?.CurrentActivity)
            .Subscribe(s =>
            {
                _log.LogDebug("TV remote activity change from {from} to {to}", s.Old?.Attributes?.CurrentActivity, s.New?.Attributes?.CurrentActivity);
                switch (s.New?.Attributes?.CurrentActivity)
                {
                    case "TV":
                    case "Film":
                        HandleOnTvOn();
                        break;
                    case "PowerOff":
                        HandleOnTvOff();
                        break;
                }
            });
    }

    // 20 minutes idle before turn off TV
    private readonly TimeSpan _idleTimeout = TimeSpan.FromMinutes(20);

    // True if we are in the process of turning on the TV
    private bool _isTurningOnTV = false;
    // If this RunScript paused the mediaplayer, it is here
    private MediaPlayerEntity? _currentlyPausedMediaPlayer;
    // The time when we stopped play media for any of the media players
    private DateTime? _timeStoppedPlaying = null;

    /// <summary>
    ///     Returns true if it is currently night
    /// </summary>
    public bool IsNight => _entities.InputSelect.HouseModeSelect?.State == "Natt";

    /// <summary>
    ///     Returns true if TV is currently on
    /// </summary>
    public bool TvIsOn => _entities.Remote.Tvrummet.IsOn();

    /// <summary>
    ///     Returns true if any of the media players is playing
    /// </summary>
    /// <returns></returns>
    public bool MediaIsPlaying => _entities.MediaPlayer.ShieldTv?.State == "playing";

    /// <summary>
    ///     Called when ever state change for the media_players playing on the TV
    /// </summary>
    public void OnMediaStateChanged(NetDaemon.HassModel.Entities.EntityState? to, NetDaemon.HassModel.Entities.EntityState? from)
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
                _scheduler.RunIn(_idleTimeout,
                    () =>
                    {
                        if (TvIsOn && !MediaIsPlaying && _timeStoppedPlaying != null)
                        {
                            if (DateTime.Now.Subtract(_timeStoppedPlaying.Value) >= _idleTimeout)
                            {
                                // Idle timeout went by without any change in state turn off TV
                                _log.LogInformation("TV been idle for {IdleTimeOut} minutes, turning off", _idleTimeout);
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
            _log.LogInformation("TV is not on, pause media {EntityId} and turn on tv!", entityId);

            // Tv and light etc is managed through a RunScript
            _services.Script.TvScene();
        }
        if (_isTurningOnTV) // Always pause media if TV is turning on
        {
            _currentlyPausedMediaPlayer = new MediaPlayerEntity(_ha, entityId);
            _currentlyPausedMediaPlayer.MediaPause();
        }
    }

    /// <summary>
    ///     When TV is on and we have paused media, play it
    /// </summary>
    public void OnTVTurnedOn()
    {
        if (_isTurningOnTV && _currentlyPausedMediaPlayer is not null)
        {
            // We had just turned on tv with this RunScript and have a media player paused
            // First delay and wait for the TV to get ready
            _log.LogDebug("TV is turning on.. Wait 9 seconds to complete...");
            _scheduler.RunIn(TimeSpan.FromSeconds(9), () =>
            {
                _isTurningOnTV = false;
                if (!MediaIsPlaying)
                {
                    _currentlyPausedMediaPlayer.MediaPlay();
                }
            });
        }
    }

    private void HandleOnTvOn()
    {
        _entities.Light.TvrumBakgrundTv.TurnOn(transition: 0, xyColor: new[] { 0.136, 0.04 });
        Thread.Sleep(200);
        _entities.Light.TvrumVagg.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.Switch.JulbelysningTvrummet.TurnOff();
        Thread.Sleep(200);
        if (_entities.Cover.TvrumRullgardinHoger?.Attributes?.Position < 100)
            _entities.Cover.TvrumRullgardinHoger.CloseCover();
        if (_entities.Cover.TvrumRullgardinVanster?.Attributes?.Position < 100)
            _entities.Cover.TvrumRullgardinVanster.CloseCover();
        Thread.Sleep(200);

    }

    private void HandleOnTvOff()
    {
        _entities.Light.TvrumBakgrundTv.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.MediaPlayer.ShieldTv.TurnOff();
        if (IsNight)
            _entities.Light.Tvrummet.TurnOn(transition: 0);
    }
}