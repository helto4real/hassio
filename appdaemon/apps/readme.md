# Applications
Here I will explain some of the applications to help you understand what they do.

## Better presence 
I wanted to make a better precense in code rather than in Hass configurations. Felt must be way easier to get the advanced things I want.

Checkout 
https://philhawthorne.com/making-home-assistants-presence-detection-not-so-binary/ as inspiration

Basically I want the state to go:

```
Home->Just left->Away->Zone

Home->Just left->Home

Away->Just arrived->Away

```

Now I can trigger a welcome message on just arrived but it will not trigger if I was temporarily Just left and got Home again.

### Group functionality
You will have to have your devices in a group. Recommed one gps, like owtracks or gpstracker, one bluetooth and one wifi like nmap. 3 devices like this gives the best result imo. 

The logic is: If any of the devices is home the group is home and if none of the devices is home the group is away.

## Cofigure in apps.yaml
```
app_presence_tomas:
  module: presence
  class: a_better_presence
  name: presence_tomas                  # name of the device in Hass
  timer: 600                            # timeout in seconds from just arrived to home and just left to away
  group_devices: group.tomas_devices    # The group that contains the trackked devices
```