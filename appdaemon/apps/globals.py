from enum import Enum

presence_state = {}
# Change this if you want to change the display name
presence_state["home"] = "Home"
presence_state["just_arrived"] = "Just arrived"
presence_state["just_left"] = "Just left"
presence_state["away"] = "Away"
presence_state["extended_away"] = "Extended away"

class GlobalEvents(Enum):
    HOUSE_MODE_CHANGED = 'HOUSE_MODE_CHANGED'
    MOTION_DETECTED = 'MOTION_DETECTED'
    MOTION_OFF = 'MOTION_OFF'

class HouseModes(Enum):
    morning = 'Morgon'
    day = 'Dag'
    evening = 'Kväll'
    night = 'Natt'