import appdaemon.plugins.hass.hassapi as hass
import threading
import  datetime
import time
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
#   timer: 600                             # timeout in seconds from just arrived to home and just left to away
#   group_devices: group.tomas_devices    # The group that contains the trackked devices
#
# Standard states:
# - Home (Home for a while)
# - Just arrived (first state that when any of the tracked devices is home)
# - Just Left (first state when all devices not_home)
# - Away (when just left for a while)
# - Extended away (when away for 24 hours not implemented yet)
# - Any zone except home
#
#   Check https://philhawthorne.com/making-home-assistants-presence-detection-not-so-binary/ as inspiration
#
# CHECK README FOR HOW TO PROPERLY SETUP TRIGGERS!!!
#

class a_better_presence(hass.Hass):

    # Initializer
    def initialize(self)->None:
        self.log("STARTING APP 'A BETTER presence2 ' for group: {} ".format(self.args["group_devices"]))

        # Check mandatory settings
        if "name" not in self.args:
            self.log("mandatory setting 'name' is missing quitting...")
            return
        if "group_devices" not in self.args:
            self.log("mandatory setting 'group_devices' is missing quitting...")
            return

        # Get the settings
        self.timeout = int(self.args.get("timer", 600))
        self.update_time = int(self.args.get("update_time", 3600))

        self._timer = None

        self.sensorname = "sensor.{}".format(self.args["name"])
        self._home_state = None

        # sensor attributes
        self.friendly_name = self.args.get('friendly_name', str)
        self.state = None
        self.last_updated = datetime.datetime.min   # the last updated time
        self.last_changed = datetime.datetime.min   # the last updated time
        self.entity_picture = None

        self.latitude = None
        self.longitude = None
        self.speed = None
        self.battery = None

        self._tracked_device_names = self.get_state( self.args["group_devices"], attribute="all" )['attributes']['entity_id']
        self.tracked_devices = self.get_tracked_devices()
        self.init_presence_tracker_state()
        self.print_devices() #debug
   
        
        self.listen_state(self.devicestate, 'device_tracker', attribute="all")
    
    def devicestate(self, entity, attribute, old, new, kwargs)->None:
        
        if entity not in self._tracked_device_names: #Not device we want
            return 

        new_device_tracker_state = device_tracker(new, self)
        
        self.update_changed_values(new_device_tracker_state, entity)

    def get_tracked_devices(self)->{}:
        tracked_devices = {}
       
        for device_name in self._tracked_device_names:
            tracked_device = self.get_state(entity=device_name, attribute="all")
            tracked_devices[device_name] = device_tracker(tracked_device, self)
          
        return tracked_devices

    def init_presence_tracker_state(self)->None:

        attributes = {}

        if len(self.friendly_name) > 0:
            attributes['friendly_name'] = self.friendly_name

        attributes['source_type'] = "gps"   #default to gps source type  
        self._home_state = self.get_home_not_home_state_from_group()
        self.state = self.get_state_from_tracked_devices()
        # Set the different kinds of attributes that could be set on the presence sensor        
        for device_name in self._tracked_device_names:
            current_device = self.tracked_devices[device_name]
            
            if current_device.entity_picture != None and 'entity_picture' not in attributes:
                attributes['entity_picture'] = current_device.entity_picture

            if current_device.source_type != None and current_device.source_type == 'gps':
                if current_device.latitude != None and 'latitude' not in attributes:
                    attributes['latitude'] = current_device.latitude

                if current_device.longitude != None and 'longitude' not in attributes:
                    attributes['longitude'] = current_device.longitude
            
                if current_device.speed != None and 'speed' not in attributes:
                    attributes['speed'] = current_device.speed

                if current_device.battery != None and 'battery' not in attributes:
                    attributes['battery'] = current_device.battery

            attributes["{}_last_updated".format(device_name)]=local_time_str(current_device.last_updated)
        
        if self.state==None:
            self.state = globals.presence_state["away"] # some bug to check for when not all device_trackers present we assume away

        self.set_state(self.sensorname, state=self.state, attributes=attributes)

    # Important to only update changed values so the tracker will behave
    # correctly when using it for state changes etc.
    def update_changed_values(self, updated_device, device_name):
        current_device = self.tracked_devices[device_name]
        updated_attributes = {}

        updated_device.print_changes(current_device)

        if updated_device.state != None and updated_device.state != current_device.state:
            current_device.state = updated_device.state

        if updated_device.last_updated != None and updated_device.last_updated != current_device.last_updated:
            current_device.last_updated = updated_device.last_updated

        if updated_device.last_changed != None and updated_device.last_changed != current_device.last_changed:
            current_device.last_changed = updated_device.last_changed

        if updated_device.source_type != None and updated_device.source_type != current_device.source_type:
            current_device.source_type = updated_device.source_type

        if updated_device.entity_picture != None and updated_device.entity_picture != current_device.entity_picture:
            current_device.entity_picture = updated_device.entity_picture
            updated_attributes['entity_picture'] = self.entity_picture

        if updated_device.latitude != None and updated_device.latitude != current_device.latitude:
            current_device.latitude = updated_device.latitude
            # set sensor gps attribute if 'gps' source type
            if current_device.source_type != None and current_device.source_type == 'gps':
                self.latitude = current_device.latitude
                updated_attributes['latitude'] = self.latitude

        if updated_device.longitude != None and updated_device.longitude != current_device.longitude:
            current_device.longitude = updated_device.longitude
            # set sensor gps attribute if 'gps' source type
            if current_device.source_type != None and current_device.source_type == 'gps':
                self.longitude = current_device.longitude
                updated_attributes['longitude'] = self.longitude
            
        if updated_device.speed != None and updated_device.speed != current_device.speed:
            current_device.speed = updated_device.speed
            # set sensor gps attribute if 'gps' source type
            if current_device.source_type != None and current_device.source_type == 'gps':
                self.speed = current_device.speed
                updated_attributes['speed'] = self.speed

        if updated_device.battery != None and updated_device.battery != current_device.battery:
            current_device.battery = updated_device.battery
            # set sensor gps attribute if 'gps' source type
            if current_device.source_type != None and current_device.source_type == 'gps':
                self.battery = current_device.battery
                updated_attributes['battery'] = self.battery

        new_state = self.get_state_from_tracked_devices()

        if new_state != self.state:
            updated_attributes["{}_last_updated".format(device_name)]=local_time_str(updated_device.last_updated)
            self.set_state(self.sensorname, state=new_state, attributes=updated_attributes)
        else:
            updated_attributes["{}_last_updated".format(device_name)]=local_time_str(updated_device.last_updated)
            self.set_state(self.sensorname, attributes=updated_attributes)
        
        self.state = new_state

    def print_devices(self):
        for device_name in self._tracked_device_names:
            self.tracked_devices[device_name].print()

    # Wifi and bluetooth home state always reports home for group
    # gps can be xxx seconds old to be counted (implements later)
    def get_home_not_home_state_from_group(self)->str:
        initial_home_state = 'not_home'
        gps_device = None
        router_device = None
        bluetooth_device = None

        for device_name in self._tracked_device_names:
            current_device = self.tracked_devices[device_name]
            if current_device.source_type != None:
                if current_device.source_type == 'bluetooth':
                    bluetooth_device = current_device
                elif current_device.source_type == 'router':
                    router_device = current_device
                elif current_device.source_type == 'gps': 
                    gps_device = current_device
                else:
                    self.log("UNKNOWN DEVICE: {}".format(current_device.source_type))  
                    if current_device.state == 'home':
                        initial_home_state = 'home'

        # Always report home if wifi or bluetooth reports 'home'
        if (bluetooth_device != None and bluetooth_device.state == 'home'):
            return 'home'  
        if (router_device != None and router_device.state == 'home'):
            return 'home'

        #if we reach here nether of the bluetooth or router is home  
        if (gps_device != None and gps_device.state == 'home'):
            if bluetooth_device!=None and self.is_updated_within_time(bluetooth_device.last_updated):  
                return 'home'
            if router_device!=None and self.is_updated_within_time(router_device.last_updated):
                return 'home'
            if self.is_updated_within_time(gps_device.last_updated):
                return 'home' #even if BT and wifi is not present within time the gps are

        return initial_home_state

    # Returns true if the last updated is not older than now-time_in_seconds or the attribute missing
    def is_updated_within_time(self, last_updated)->bool:
        
        diff = datetime.datetime.now(datetime.timezone.utc) - last_updated
        if diff.days == 0 and diff.seconds< self.update_time: 
            return True
        else:
            return False


    # Gets the state from the gps device
    def get_gps_state(self):
        for device_name in self._tracked_device_names:
            current_device = self.tracked_devices[device_name]
            if current_device.source_type != None and current_device.source_type == 'gps':
                return current_device.state
        
        return None

    def get_state_from_tracked_devices(self):
        
        if self._timer != None: # We have a timer running so we wait to update new state
            return self.state

        new_home_state = self.get_home_not_home_state_from_group()

        if self._home_state != new_home_state: # e.i changed from home/not_home to home/not_home
            self._home_state = new_home_state
            if new_home_state == 'home':
                if self.state != globals.presence_state["just_left"]:
                    self.set_timer()
                    return globals.presence_state["just_arrived"]
                else:
                    return globals.presence_state["home"]
                
            else:
                if self.state != globals.presence_state["just_arrived"]:
                    self.set_timer()
                    return globals.presence_state["just_left"]
                else:
                    return globals.presence_state["away"]
        else:
            if new_home_state == 'not_home':
                # find gps state if same and group is not home
                # so we can get the 
                gps_state = self.get_gps_state()
                if gps_state != None:
                    if gps_state == 'not_home' or gps_state == 'home': # if home then too old return away anyway
                        return globals.presence_state["away"]
                    else:
                        return gps_state
            else:
                return globals.presence_state["home"]

        return self.state #set to current one as default
    
    # Set timer
    def set_timer(self)->None:
        
        if self._timer != None:
            return

        self._timer = threading.Timer(self.timeout, self.on_timer)
        self._timer.start()
   
    def on_timer(self)->None:
        self._timer = None
        current_state = self.get_state_from_tracked_devices()

        if current_state != self.state:
     #       self.log("ON TIMER CHANGED STATE FROM {} TO {}".format(self.state, current_state))
            self.state = current_state
            self.set_state(self.sensorname, state=self.state)


# Information in         
class device_tracker:
    def __init__(self, hass_device_state, app):
        
        self._app = app

        # standard object 
        self.name = hass_device_state['entity_id']  # name of the device , device_tracker.name  
        self.state = hass_device_state['state']     # name of the device , device_tracker.name  
        self.last_updated = datetime.datetime.min   # the last updated time
        self.last_changed = datetime.datetime.min   # the last updated time
        self.entity_picture = None

        # standard attributes
        self.source_type = None                     # i.e. gps, router etc.        
        
        # gps attributes
        self.latitude = None
        self.longitude = None
        self.speed = None
        self.battery = None

        if 'last_updated' in hass_device_state:
            self.last_updated = self._parse_date_time_string(hass_device_state['last_updated'])

        if 'last_changed' in hass_device_state:
            self.last_changed = self._parse_date_time_string(hass_device_state['last_changed'])

        self._read_attributes(hass_device_state)

    def _read_attributes(self, hass_device_state):
        if 'attributes' not in hass_device_state:
            return                                  # No attributes weird but true
        attr = hass_device_state['attributes']    
        
        if 'source_type' in attr:
            self.source_type = attr['source_type']
        
        if 'entity_picture' in attr:
            self.entity_picture = attr['entity_picture']

        # gps attributes

        if 'latitude' in attr:
            self.latitude = attr['latitude']
        if 'longitude' in attr:
            self.longitude = attr['longitude']
        if 'speed' in attr:
            self.speed = attr['speed']
        if 'battery' in attr:
            self.battery = attr['battery']

    def print(self):
        return # remove to debug changes
        self._app.log("------------------------------------------")
        self._app.log("TRACKED DEVICE:   {}".format(self.name))
        self._app.log("state:            {}".format(self.state))
        self._app.log("last_updated:     {}".format(local_time_str(self.last_updated)))
        self._app.log("last_changed:     {}".format(local_time_str(self.last_changed)))

        if (self.source_type != None):
            self._app.log("source_type:      {}".format(self.source_type))
 
        if (self.entity_picture != None):
            self._app.log("entity_picture:      {}".format(self.entity_picture))

        #gps
        if (self.latitude != None):
            self._app.log("latitude:         {}".format(self.latitude))
        if (self.longitude != None):
            self._app.log("longitude:        {}".format(self.longitude))
        if (self.speed != None):
            self._app.log("speed:            {}".format(self.speed))
        if (self.battery != None):
            self._app.log("battery:          {}".format(self.battery))

    def print_changes(self, old_device_state):
        return # remove to debug changes
        self._app.log("------------------------------------------")
        self._app.log("CHANGED DEVICE:   {}".format(self.name))

        if (self.source_type != None):  # Always pring sourcetype for clearity in logs
            self._app.log("source_type:      {}".format(self.source_type))

        if (self.state != old_device_state.state):
            self._app.log("state:            {}".format(self.state))
        
        if (self.entity_picture != None and self.entity_picture != old_device_state.entity_picture):  
            self._app.log("entity_picture:      {}".format(self.entity_picture))

        if (self.last_updated != None and self.last_updated != old_device_state.last_updated):
            self._app.log("last_updated:     {}".format(local_time_str(self.last_updated)))
        
        if (self.last_changed != None and self.last_changed != old_device_state.last_changed):
            self._app.log("last_changed:     {}".format(local_time_str(self.last_changed)))


        if (self.latitude != None and self.latitude != old_device_state.latitude):
            self._app.log("latitude:         {}".format(self.latitude))
        if (self.longitude != None and self.longitude != old_device_state.longitude):
            self._app.log("longitude:        {}".format(self.longitude))
        if (self.speed != None and self.speed != old_device_state.speed):
            self._app.log("speed:            {}".format(self.speed))
        if (self.battery != None and self.battery != old_device_state.battery):
            self._app.log("battery:          {}".format(self.battery))

    # Assumes format dateTtime.microsecods+00:00 , feels like ugly code but what the hell
    def _parse_date_time_string(self, datetimestring:str):
        lenToUTC = len(datetimestring)-6
        strToParse = datetimestring[:lenToUTC]+datetimestring[lenToUTC:lenToUTC+3]+datetimestring[lenToUTC+4:]
        return datetime.datetime.strptime(strToParse, '%Y-%m-%dT%H:%M:%S.%f%z')

####
# Common functions

# converts to local time for printing
def local_time_str(utc_datetime):
    now_timestamp = time.time()
    offset = datetime.datetime.fromtimestamp(now_timestamp) - datetime.datetime.utcfromtimestamp(now_timestamp)
    local_datetime = utc_datetime + offset
    return local_datetime.strftime("%Y-%m-%d %H:%M")