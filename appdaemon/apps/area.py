from base import Base
from globals import GlobalEvents, HouseModes
from typing import Tuple, Union

"""
A class that are the base class of all rooms and areas where devices are present.

Define _ambient_lights that will turn_off/turn_on depending on house state.

Inherit from this class and override default beahviour for specific needs in specific rooms

"""
class Area(Base):
    
    def initialize(self) -> None:
        super().initialize()
        self._ambient_lights = self.args.get('ambient_ligts', {})
        self._night_lights = self.args.get('night_lights', {})
        self._motion_sensors = self.args.get('motion_sensors', {})
        self._min_time_motion = 10*60

        self.listen_event(
            self.__on_house_home_changed,
            GlobalEvents.HOUSE_MODE_CHANGED.value)

        self._night_light_on = False

        self.__init_motion_sensors()

    def __init_motion_sensors(self):
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
        """called when house mode changes"""

        self.on_motion_detected(entity)    
    
    def __off_motion(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """called when house mode changes"""
        
        self.off_motion_detected(entity)    

    def on_motion_detected(self, entity:str)->None:
        self.log("house_state={} and night_ligt_stateus={}".format(self.house_status.is_night(), self._night_light_on))
        if self.house_status.is_night()==False or self._night_light_on == True:
            return
        for night_light in self._night_lights:
            self.turn_on(night_light)
        self._night_light_on = True

    def off_motion_detected(self, entity:str)->None:
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