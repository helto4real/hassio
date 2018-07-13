# Media related apps
## sr_play_program
Application that stream from Swedish Radio latest program with program id = xxx
I use it to stream latest news from "Ekot" 

send event "APP_SR_PLAY_PROGRAM"

```
script:
    stream_ekot:
        sequence:
        - event: APP_SR_PLAY_PROGRAM
            event_data:
            program_id: "4540"
            entity_id: "media_player.sovrum"

```

## tv
Handles the automations and actions related to tv:s

Following use-cases:
- Turn on TV when I start playing on my media player
  it automatically pauses for an amount of time to give the TV
  a chance to turn on and then play again
- Turn off tv if media_player been idle or off for an amout of time
  (I only have chromecast on this TV but if you use it to watch live TV the use-case makes no sense)