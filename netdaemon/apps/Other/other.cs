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
        RunEvery(TimeSpan.FromMinutes(30), () =>
        {
            var tempFreezer = State("sensor.kok_frys_temp")?.State;

            if (tempFreezer is double)
            {
                if (tempFreezer > -15.0)
                {
                    Speak("media_player.huset", "Viktigt meddelande, Frysen uppe har får låg temperatur"); // Important message
                    this.Notify("Viktigt meddelande, Frysen uppe har får låg temperatur!");
                }
            }

        });
    }
}