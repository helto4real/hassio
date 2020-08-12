using System;
using System.Threading.Tasks;
using NetDaemon.Common.Reactive;
using System.Reactive.Linq;

/// <summary>
///     App docs
/// </summary>
public class GoogleCalendarManager : NetDaemonRxApp
{

    public string? Calendar { get; set; }
    public override Task InitializeAsync()
    {
        Entity(Calendar!)
            .StateChanges.Where(e => e.New.State == "on")
            .Subscribe(s =>
            {
                Speak("media_player.huset", "Viktigt meddelande"); // Important message
                Speak("media_player.huset", s.New?.Attribute?.message);
                Speak("media_player.huset", s.New?.Attribute?.description);
            });

        return Task.CompletedTask;
    }
}