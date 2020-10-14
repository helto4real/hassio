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
public class OtherApp : NetDaemonRxApp
{

    public override void Initialize()
    {
        Entity("sensor.kok_frys_temp")
            .StateChanges
            .Where(e => e.New?.State is double && e.New?.State > -11.0 || e.New?.State is long && e.New?.State > -11)
            .Throttle(TimeSpan.FromMinutes(30))
            .Subscribe(s =>
            {
                var temp = State("sensor.kok_frys_temp")?.State;
                if (temp is double && temp > -11.0 || temp is long && temp > -11)
                {
                    Speak("media_player.huset", "Viktigt meddelande, Frysen uppe har får låg temperatur"); // Important message
                    this.Notify("Viktigt meddelande, Frysen uppe har får låg temperatur!");
                }
            }
            );
    }
}