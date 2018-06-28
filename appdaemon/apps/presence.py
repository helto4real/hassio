import appdaemon.plugins.hass.hassapi as hass
import threading
import  datetime
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
#   name: presence_tomas                  # name of the device in Hass
#   timer: 10                             # timeout in seconds from just arrived to home and just left to away
#   entity_picture: /local/tomas.jpg      # Entity picture (optional)
#   group_devices: group.tomas_devices    # The group that contains the trackked devices
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
# CHECK README FOR HOW TO PROPERLY SETUP TRIGGERS!!!
#

class a_better_presence(hass.Hass):

    # Initializer
    def initialize(self):
        self.log("STARTING APP 'A BETTER presence' for group: {} ".format(self.args["group_devices"]))

        self.devices = self.get_state( self.args["group_devices"], attribute="all" )['attributes']['entity_id']
        self.sensorname = "sensor.{}".format(self.args["name"])
        self.timeout = int(self.args["timer"])
        
        # for setting different attributes we get from gps enabled device in group (tested with gpstracker)
        self.enity_picture = None
        if "entity_picture" in self.args:
            self.enity_picture = self.args["entity_picture"]
        
        # for skipping last updated control and always will render Home when home
        self.prio_device = None
        if "prio_device" in self.args:
            self.prio_device = self.args["prio_device"]
        
        # min age of the update time to be considered as home if older it is not valid and considered as not_home
        # Default to 10 minutes
        self.update_time = 600 
        if "update_time" in self.args:
            self.update_time = self.args["update_time"]

        self.longitude = None
        self.latitude = None
        self.battery = None
        self.speed = None
        self.source_type = None

        self.get_device_states()
        
        self._last_state_before_timer = "unknown"            # Tracks state before timer 
        self._last_away_home_state = "unknown"               # Tracks group home/away state
        self.state = "unknown"                               # Actual state of the sensor
        
        self.listen_state(self.devicestate, 'device_tracker', attribute="all")
        self.run_minutely(self.check_old_states, datetime.time(0, 0, 0))
        self._timer = None
        self.init_presence_state()

    # Assumes format dateTtime.microsecods+00:00 , feels like ugly code but what the hell
    def parse_date_time_string(self, datetimestring:str):
        lenToUTC = len(datetimestring)-6
        strToParse = datetimestring[:lenToUTC]+datetimestring[lenToUTC:lenToUTC+3]+datetimestring[lenToUTC+4:]
        return datetime.datetime.strptime(strToParse, '%Y-%m-%dT%H:%M:%S.%f%z')

    # Returns true if the last updated is not older than now-time_in_seconds or the attribute missing
    def is_updated_within_time(self, device_state):
        
        if 'last_updated' in device_state: # and 'last_changed' in device_state:
            dtLastUpdated = self.parse_date_time_string(device_state['last_updated'])
            diff = datetime.datetime.now(datetime.timezone.utc) - dtLastUpdated
            
            if diff.days == 0 and diff.seconds< self.update_time: 
                return True
            else:
                return False

        return True

    # gets the current device states and put the values devicestates dictionary
    def get_device_states(self):
        self.device_states = {}
        for device in self.devices:
            device_state = self.get_state(device, attribute="all")
            self.device_states[device]=device_state
    # Sets sensor state to given state, uses the global
    # names for known states
    def set_sensor_state(self, state):
        state_to_set = "Unknown"
        if state in globals.presence_state:
            state_to_set = globals.presence_state[state]
        else:
            state_to_set = state

        attributes = {}

        if self.enity_picture != None:
            attributes['entity_picture'] = self.enity_picture
        if self.source_type != None:
            attributes['source_type'] = self.source_type
        if self.longitude != None:
            attributes['longitude'] = self.longitude
        if self.latitude != None:
            attributes['latitude'] = self.latitude
        if self.battery != None:
            attributes['battery'] = self.battery
        if self.longitude != None:
            attributes['speed'] = self.speed


        self.set_state(self.sensorname, state=state_to_set, attributes=attributes)

        self.state = state_to_set
        self._last_away_home_state = state

    def check_old_states(self, kwargs):
        self.refresh_presence_state()

    # Callback funktion for all device state changes
    def devicestate(self, entity, attribute, old, new, kwargs):
        
        if entity not in self.devices: #Not device we want
            return 

        new_state = new['state']
        old_state = old['state']

        #self.log(new)                      #enable if you want to debugprint stateobject
        self.device_states[entity]=new
        if new_state != old_state:
            self.log("{} changed status from {} to {}".format(entity, old_state, new_state))
            self.refresh_presence_state()
    # Parse and set gps device attributes
    def set_gps_attributes(self, attributes):
        
        if 'latitude' in attributes:
            self.latitude = attributes['latitude']
        if 'source_type' in attributes:
            self.source_type = attributes['source_type']
        if 'longitude' in attributes:
            self.longitude = attributes['longitude']
        if 'speed' in attributes:
            self.speed = attributes['speed']
        if 'battery' in attributes:
            self.battery = attributes['battery']

    # Returns true if device attributes is a gps device else false
    def is_gps_device(self, attributes):
        if 'source_type' in attributes and attributes['source_type']=='gps' and 'latitude' in attributes :
            return True
        else:
            return False

    # Gets the group state of all devices. if prio_device is home, all group is homne
    # else only devices that are recently updated that can be considered as home
    # if gps device is in a zone, the state is the zone name else away     
    def get_group_state(self):
        group_state = 'away'
        self.log("'{}' is the priodevice".format(self.prio_device))
        for device_name in self.devices:
            state = self.device_states[device_name]
            if state['state'] == 'home':
                if device_name == self.prio_device:
                    self.log("PrioDevice is Home: {}".format(device_name))
                    # we have a prioritzed device
                    group_state = 'home'
                    if self.is_gps_device(state['attributes']):
                        self.set_gps_attributes(state['attributes']) 
                    return group_state
                else:
                    if self.is_updated_within_time(state): 
                        group_state = 'home'
                        if self.is_gps_device(state['attributes']):
                            self.set_gps_attributes(state['attributes']) 
                    else:
                        self.log("Warning: {} is updatetime is too old: {}".format(device_name, state['last_updated']))
                        
            else:
                if self.is_gps_device(state['attributes']):
                    if group_state != 'home' and state['state']!="not_home":
                        group_state = state['state']
                
                    self.set_gps_attributes(state['attributes'])    
                    

        return group_state

    # presence state is set depending on state of the tracked devices
    # any device is 'home', then the sensor state is 'home' 
    def refresh_presence_state(self):
        group_state = self.get_group_state()

        if self._last_away_home_state == group_state:
            return # Nothing more to do, same state
        
        if group_state != "home" and self._last_away_home_state=="home":
            # We just left
            self.set_sensor_state("just_left")
            self._last_state_before_timer = group_state #used to get real state after timer
            self.set_timer()
        elif group_state == "home":
            # Just arrived
            if self._last_away_home_state != "just_left":
                self.set_sensor_state("just_arrived")
                self._last_state_before_timer = group_state #used to get real state after timer
                self.set_timer()
            elif self._last_away_home_state != "just_arrived":
                self.cancel_timer()
                self.set_sensor_state("home")
                self._last_state_before_timer = group_state #used to get real state after timer
        else:
            self.cancel_timer() #Cancel just in case its in just_left or just_arrived
            self.set_sensor_state(group_state)
            self._last_away_home_state = group_state
        
        
    #initialization of state when everything starts up    
    def init_presence_state(self):
        group_state = self.get_group_state()
        self.set_sensor_state(group_state)

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
            
    # Gets called when timeout
    # if just arrived, set to home else just left set to the real state
    def on_timer(self):
        if self.state == globals.presence_state["just_arrived"]:
            self.set_sensor_state("home")
        elif self.state == globals.presence_state["just_left"]:
            self.set_sensor_state(self._last_state_before_timer) #make sure we set the real state 