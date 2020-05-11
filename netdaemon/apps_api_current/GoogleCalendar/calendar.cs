using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public class GoogleCalendarManager : NetDaemonApp
{

    public string? Calendar { get; set; }
    public override Task InitializeAsync()
    {
        Entity(Calendar!)
            .WhenStateChange(to: "on")
                .Call((entityId, newState, oldState) =>
               {
                   Speak("media_player.huset", "Viktigt meddelande"); // Important message
                   Speak("media_player.huset", newState?.Attribute?.message);
                   Speak("media_player.huset", newState?.Attribute?.description);
                   return Task.CompletedTask;
               }).Execute();

        return Task.CompletedTask;
    }
}