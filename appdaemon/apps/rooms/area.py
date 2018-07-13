from base import Base
from globals import GlobalEvents, HouseModes
from typing import Tuple, Union

"""
A class that are the base class of all rooms and areas where devices are present.

- Define ambient_lights and they will turn_off/turn_on depending on house state.
- Define motion sensors and nightlights and it will turn on at night when motion
  and turn off after a time without motion. Event EV_MOTION_DETECTED/EV_MOTION_OFF 
  will be sent with room and entity

Inherit from this class and override default beahviour for specific needs in specific rooms

"""
class Area(Base):
    
    def initialize(self) -> None:
        super().initialize()
        self._ambient_lights = self.args.get('ambient_ligts', {})
        self._night_lights = self.args.get('night_lights', {})
        self._motion_sensors = self.args.get('motion_sensors', {})
        self._light_switches = self.args.get('light_switches', {})

        self._min_time_motion = int(self.properties.get('min_time_motion', 10))*60
        self._min_time_nightlights = int(self.properties.get('min_time_nightlights', 0))*60

        self.listen_event(
            self.__on_house_home_changed,
            GlobalEvents.EV_HOUSE_MODE_CHANGED.value)

        self._night_light_on = False

        self.__init_motion_sensors()
        self.__init_light_switches()

    def __init_motion_sensors(self)->None:
        for motion_sensor in self._motion_sensors:
            # listen to motion
            self.listen_state(
                self.__on_motion,
                motion_sensor,
                new='on',
                old='off')

            # listen to motion
            self.listen_state(
                self.__off_motion,
                motion_sensor,
                new='off',
                old='on',
                duration=self._min_time_motion)

            # listen to motion off for nightlight function
            self.listen_state(
                self.__nightlight_off,
                motion_sensor,
                new='off',
                old='on',
                duration=self._min_time_nightlights)

    def __init_light_switches(self)->None:
        for light_switch in self._light_switches:
            # listen to motion
            self.listen_state(
                self.__on_lightswich_state_changed,
                light_switch)

    def motion_on_detected(self, entity:str)->None:
        """called when motion detected in area"""
        if self.house_status.is_night()==False or self._night_light_on == True:
            return
        for night_light in self._night_lights:
            self.turn_on(night_light)
        self._night_light_on = True

    def motion_off_detected(self, entity:str)->None:
        """called when motion off in area"""
        

    def nightlights_off_detected(self, entity:str)->None:
        """called when nighlights are off in area"""
        if self._night_light_on == False:
            return
        for night_light in self._night_lights:
            self.turn_off(night_light)
     
        self._night_light_on = False

    def on_housemode_day(self, old: HouseModes) -> None:
        self.__turn_off_ambient()
    
    def on_housemode_morning(self, old: HouseModes) -> None:
        self.__turn_off_ambient()
    
    def on_housemode_evening(self, old: HouseModes) -> None:
        self.__turn_on_ambient()

    def on_housemode_night(self, old: HouseModes) -> None:
        self.__turn_off_ambient()

    def on_lightswich_state_changed(self, entity: str, old: str, new: str)->None:
       return

    def __turn_on_ambient(self)->None:
        if len(self._ambient_lights) == 0:
            return  # No ambient lights

        for light in self._ambient_lights:
            self.turn_on(light)    

    def __turn_off_ambient(self)->None:
        if len(self._ambient_lights) == 0:
            return  # No ambient lights

        for light in self._ambient_lights:
            self.turn_off(light)    

    '''
    
    Callback functions from hass. 
    
    '''
    def __on_house_home_changed(
        self, event_name: str, data: dict, kwargs: dict) -> None:
        newMode = HouseModes(data['new'])
        oldMode = HouseModes(data['old'])

        if newMode == HouseModes.day:
            self.on_housemode_day(oldMode)
        elif newMode == HouseModes.evening:
            self.on_housemode_evening(oldMode)
        elif newMode == HouseModes.night:
            self.on_housemode_night(oldMode)
        elif newMode == HouseModes.morning:
            self.on_housemode_morning(oldMode)

    def __on_motion(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """callback when motion detected in area"""
        self.fire_event(
            GlobalEvents.EV_MOTION_DETECTED.value, 
            entity=entity,
            area=self.name) 
            
        self.motion_on_detected(entity)    
    
    def __off_motion(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """callback motion off in area"""
        self.fire_event(
            GlobalEvents.EV_MOTION_OFF.value, 
            entity=entity,
            area=self.name)
                 
        self.motion_off_detected(entity)    

    def __on_lightswich_state_changed(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """callback motion off in area"""
        self.log("LIGHTSWITCH {} STATE: {}".format(entity, new))    

        self.on_lightswich_state_changed(entity, old, new)

    def __nightlight_off(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """callback nightlight off in area"""
        
        self.nightlights_off_detected(entity)