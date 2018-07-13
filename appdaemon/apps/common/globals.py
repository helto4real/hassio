from enum import Enum

"""
Global definitions that are used everywhere in my automations for easy access

"""

presence_state = {}
# Change this if you want to change the display name
presence_state["home"] = "Home"
presence_state["just_arrived"] = "Just arrived"
presence_state["just_left"] = "Just left"
presence_state["away"] = "Away"
presence_state["extended_away"] = "Extended away"

PEOPLE = {
    'Tomas': {
        'device_tracker': 'sensor.presence_tomas',
        'notifiers': ['th']
    },
    'Elin': {
        'device_tracker': 'sensor.presence_elin',
        'notifiers': ['eh']
    }
}
class GlobalEvents(Enum):
    ## Events
    # fired when house mode chages, i.e. day, evening, night, morning
    EV_HOUSE_MODE_CHANGED = 'EV_HOUSE_MODE_CHANGED'
    # any motion detected in a room
    EV_MOTION_DETECTED = 'EV_MOTION_DETECTED'
    EV_MOTION_OFF = 'EV_MOTION_OFF'
    # fires when alarm on a google home device
    EV_ALARM_CLOCK_ALARM = 'EV_ALARM_CLOCK_ALARM'

    ## Commands
    # play a program with a specific program id (see sr.se api for details)
    CMD_SR_PLAY_PROGRAM = 'CMD_SR_PLAY_PROGRAM'
    # send notification
    CMD_NOTIFY = 'CMD_NOTIFY'
    # send notification with greeting
    CMD_NOTIFY_GREET = 'CMD_NOTIFY_GREET'

class HouseModes(Enum):
    morning = 'Morgon'
    day = 'Dag'
    evening = 'Kväll'
    night = 'Natt'