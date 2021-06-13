using System;
using System.Threading.Tasks;
using NetDaemon.Common.Reactive;
using System.Reactive.Linq;

/// <summary>
///     Pushes important calendar events to TTS.
/// </summary>
public class WakeupRoutineManager : NetDaemonRxApp
{

    public string? AlarmSensor { get; set; }

    public override void Initialize()
    {
        Entity(AlarmSensor!)
            .StateChanges.Where(e => 
                e.New.Attribute?.next_alarm_status == "ringing" && 
                e.Old.Attribute?.next_alarm_status != "ringing")
            .Subscribe(s =>
            {
                // make a short delay
                RunIn(TimeSpan.FromSeconds(30), () => Speak("media_player.sovrum", "du har satt larm!"));
            });
    }
}