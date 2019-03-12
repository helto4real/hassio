from enum import Enum

"""
Global definitions that are used everywhere in my automations for easy access

"""

presence_state = {}
# Change this if you want to change the display name
presence_state["home"] = "Hemma"
presence_state["just_arrived"] = "Nyss anlänt"
presence_state["just_left"] = "Nyss åkt"
presence_state["away"] = "Borta"
presence_state["extended_away"] = "Extended away"

PEOPLE = {
    'Tomas': {
        'person': 'person.tomas',
        'device_tracker': 'device_tracker.tomas_presence',
        'proximity': 'proximity.prox_home_tomas',
        'notifiers': ['discord_webhook']
    },
    'Elin': {
        'person': 'person.elin',
        'device_tracker': 'device_tracker.elin_presence',
        'proximity': 'proximity.prox_home_elin',
        'notifiers': ['eh']
    },
    'Sally': {
        'person': 'person.sally',
        'device_tracker': 'device_tracker.sally_presence',
        'proximity': 'proximity.prox_home_sally',
        'notifiers': ['sh']
    },
    'Melker': {
        'person': 'person.melker',
        'device_tracker': 'device_tracker.melker_presence',
        'proximity': 'proximity.prox_home_melker',
        'notifiers': ['mh']
    }
}


class GlobalEvents(Enum):
    # Events
    # fired when house mode chages, i.e. day, evening, night, morning
    EV_HOUSE_MODE_CHANGED = 'EV_HOUSE_MODE_CHANGED'
    # any motion detected in a room
    EV_MOTION_DETECTED = 'EV_MOTION_DETECTED'
    EV_MOTION_OFF = 'EV_MOTION_OFF'
    # fires when alarm on a google home device
    EV_ALARM_CLOCK_ALARM = 'EV_ALARM_CLOCK_ALARM'

    # Commands
    # play a program with a specific program id (see sr.se api for details)
    CMD_SR_PLAY_PROGRAM = 'CMD_SR_PLAY_PROGRAM'
    # send notification
    CMD_NOTIFY = 'CMD_NOTIFY'
    # send notification with greeting
    CMD_NOTIFY_GREET = 'CMD_NOTIFY_GREET'
    # turn on ambient lights
    CMD_AMBIENT_LIGHTS_ON = 'CMD_AMBIENT_LIGHTS_ON'
    # turn off ambient lights
    CMD_AMBIENT_LIGHTS_OFF = 'CMD_AMBIENT_LIGTS_OFF'


class HouseModes(Enum):
    morning = 'Morgon'
    day = 'Dag'
    evening = 'Kväll'
    night = 'Natt'
    cleaning = 'Städning' #all lights on

