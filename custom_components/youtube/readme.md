# Youtube sensor
Gets the number of subscribers from a channel id using an api key.

## Install
Copy the whole folder `youtube` to your `custom_compoenents` folder under configuration.

## Config
You will need the channel id and a google api key to use the sensor.
### Get the google API key
Please see [google official docs](https://developers.google.com/youtube/v3/getting-started) to get your key. 
### Get the Youtube channel id
Use browser to get to the channel you want to follow. Then the url should be something like `https://www.youtube.com/channel/UCMxSJuAU_4N94bh4zW9rUtg` then the channel id is `UCMxSJuAU_4N94bh4zW9rUtg`

### Home assistant configuration
The yaml should look like something like this
```yaml
sensor:
  - platform: youtube
    entities:
      your_name:
          channel_id: 'UCMxSJuAU_4N94bh4zW9rUtg' # Substitute to your channel
          key: 'yourkey' # Use your key
```