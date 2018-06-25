import appdaemon.plugins.hass.hassapi as hass
import threading
import globals
###############################################################################
# A better presence sensor function
#
# Takes a group with 1-x tracked_devices. Preferable one and only one with gps
# if any of the devices is home then the sensor is home
#
# apps.yaml example
# 
# app_presence_tomas:
#   module: presence
#   class: a_better_presence
#   group_devices: group.tomas_devices
#
# Standard states:
# - Home (Home for a while)
# - Just arrived (first state that when any of the tracked devices is home)
# - Just Left (first state when all devices not_home)
# - Away (when just left for a while)
# - Extended away (when away for 24 hours)
# - Any zone except home
#
#   Check https://philhawthorne.com/making-home-assistants-presence-detection-not-so-binary/ as inspiration
#

class a_better_presence(hass.Hass):

    # Initializer
    def initialize(self):
        self.log("STARTING APP 'A BETTER presence' for group: {} ".format(self.args["group_devices"]))

        

        self.devices = self.get_state( self.args["group_devices"], attribute="all" )['attributes']['entity_id']
        self.sensorname = "sensor.{}".format(self.args["name"])
        self.timeout = int(self.args["timer"])
        self.get_device_states()
        
        self._last_state_before_timer = "unknown"            # Tracks state before timer 
        self._last_away_home_state = "unknown"               # Tracks group home/away state
        self.state = "unknown"                               # Actual state of the sensor
        
        self.listen_state(self.devicestate, 'device_tracker', attribute="all")
        
        self._timer = None
        self.init_presence_state()

    # gets the current device states and put the values devicestates dictionary
    def get_device_states(self):
        self.device_states = {}
        for device in self.devices:
            device_state = self.get_state(device, attribute="all")
            self.device_states[device]=device_state


    # Sets sensor state to given state, uses the global
    # names for known states
    def set_sensor_state(self, state, attributes):
        state_to_set = "Unknown"
        if state in globals.presence_state:
            state_to_set = globals.presence_state[state]
        else:
            state_to_set = state

        self.set_state(self.sensorname, state=state_to_set, attributes=attributes)

        self.state = state_to_set
        self._last_away_home_state = state

    # Callback funktion for all device state changes
    def devicestate(self, entity, attribute, old, new, kwargs):
        
        if entity not in self.devices: #Not device we want
            return 

        new_state = new['state']
        old_state = old['state']

        self.log(new)
        self.device_states[entity]=new
        if new_state != old_state:
            self.log("{} changed status from {} to {}".format(entity, old_state, new_state))
            self.refresh_presence_state()


    # Gets the group state of all devices. one home, the groupstate is home
    # if in a zone, the state is the zone name else away     
    def get_group_state(self):
        group_state = 'away'
        
        for device_name in self.devices:
            state = self.device_states[device_name]
            if state['state'] == 'home':
                group_state = 'home'
                break
            else:
                if state['attributes']['source_type']=='gps' and 'latitude' in state['attributes'] and state['state']!="not_home":
                    group_state = state['state']

        return group_state

    # presence state is set depending on state of the tracked devices
    # any device is 'home', then the sensor state is 'home' 
    def refresh_presence_state(self):
        group_state = self.get_group_state()

        if self._last_away_home_state == group_state:
            return # Nothing more to do, same state
        
        if group_state != "home" and self._last_away_home_state=="home":
            # We just left
            #self._last_away_home_state ="just_left"
            self.set_sensor_state("just_left", '')
            self._last_state_before_timer = group_state #used to get real state after timer
            self.set_timer()
        elif group_state == "home":
            # Just arrived
            if self._last_away_home_state != "just_left":
                self.set_sensor_state("just_arrived", '')
                self._last_state_before_timer = group_state #used to get real state after timer
                self.set_timer()
            elif self._last_away_home_state != "just_arrived":
                self.cancel_timer()
                self.set_sensor_state("home", '')
                self._last_state_before_timer = group_state #used to get real state after timer
        else:
            self.cancel_timer() #Cancel just in case its in just_left or just_arrived
            self.set_sensor_state(group_state, '')
            self._last_away_home_state = group_state
        
        
        
    def init_presence_state(self):
        group_state = self.get_group_state()
        self.set_sensor_state(group_state, '')

    # Set timer
    def set_timer(self):
        
        if self._timer != None:
            self._timer.cancel()
            
        self._timer = threading.Timer(self.timeout, self.on_timer)
        self._timer.start()
    # Set timer
    def cancel_timer(self):
        if self._timer != None:
            self._timer.cancel()
            self._timer = None
   
    def on_timer(self):
        self.log("timer: lastaway:{} laststate:{}".format(self._last_away_home_state, self._last_state_before_timer))
        if self.state == globals.presence_state["just_arrived"]:
            self.set_sensor_state("home", '')
        elif self.state == globals.presence_state["just_left"]:
            self.set_sensor_state(self._last_state_before_timer, '')