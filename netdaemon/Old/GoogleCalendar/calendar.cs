using System;
using NetDaemon.Common;
using NetDaemon.HassModel.Common;
using HomeAssistantGenerated;
using NetDaemon.Daemon;
using System.Reactive.Linq;

/// <summary>
///     Pushes important calendar events to TTS.
/// </summary>
[NetDaemonApp]
public class GoogleCalendarManager
{
    public ITextToSpeechService _tts;
    public GoogleCalendarManager(IHaContext ha, ITextToSpeechService tts)
    {
        _tts = tts;
        var entities = new Entities(ha);
        entities.Calendar.TaUtSopor
            .StateChanges
            .Where(e => e.New?.State == "on")
            .Subscribe(s =>
                {
                    _tts.Speak("media_player.huset", "Viktigt meddelande"); // Important message
                    if (s.New?.Attributes?.Message is not null)
                        _tts.Speak("media_player.huset", s.New.Attributes.Message);
                    if (s.New?.Attributes?.Description is not null)
                        _tts.Speak("media_player.huset", s.New.Attributes.Description);
                }
            );
    }
}



// using System;
// using System.Threading.Tasks;
// using NetDaemon.Common.Reactive;
// using System.Reactive.Linq;

// /// <summary>
// ///     Pushes important calendar events to TTS.
// /// </summary>
// public class GoogleCalendarManager : NetDaemonRxApp
// {

//     public string? Calendar { get; set; }
//     public override Task InitializeAsync()
//     {
//         Entity(Calendar!)
//             .StateChanges.Where(e => e.New.State == "on")
//             .Subscribe(s =>
//             {
//                 Speak("media_player.huset", "Viktigt meddelande"); // Important message
//                 Speak("media_player.huset", s.New?.Attribute?.message);
//                 Speak("media_player.huset", s.New?.Attribute?.description);
//             });

//         return Task.CompletedTask;
//     }
// }