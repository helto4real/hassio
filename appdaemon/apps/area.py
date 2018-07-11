from base import Base
from globals import GlobalEvents, HouseModes

"""
A class that are the base class of all rooms and areas where devices are present.

Define ambient_lights that will turn_off/turn_on depending on house state.

Inherit from this class and override default beahviour for specific needs in specific rooms

"""
class Area(Base):
    
    def initialize(self) -> None:
        super().initialize()
        self.ambient_lights = self.args.get('ambient_ligts', {})
       
        self.listen_event(
            self.__on_house_home_changed,
            GlobalEvents.HOUSE_MODE_CHANGED.value)


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

    def on_housemode_day(self, old: HouseModes) -> None:
        self.__turn_off_ambient()
    
    def on_housemode_morning(self, old: HouseModes) -> None:
        self.__turn_off_ambient()
    
    def on_housemode_evening(self, old: HouseModes) -> None:
        self.__turn_on_ambient()

    def on_housemode_night(self, old: HouseModes) -> None:
        self.__turn_off_ambient()

    def __turn_on_ambient(self)->None:
        if len(self.ambient_lights) == 0:
            return  # No ambient lights

        for light in self.ambient_lights:
            self.turn_on(light)    

    def __turn_off_ambient(self)->None:
        if len(self.ambient_lights) == 0:
            return  # No ambient lights

        for light in self.ambient_lights:
            self.turn_off(light)    