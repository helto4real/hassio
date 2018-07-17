from area import Area
from globals import GlobalEvents, HouseModes
from typing import Tuple, Union

'''
A specific superclass of Area as an example of how you could 
superclass Area and work on your own room details

Important to keep the "super()...." to make default area behaviour work

- turn on/off computer depending on motion and time

'''
class TomasRoom(Area):
    def initialize(self) -> None:
        super().initialize()

        self._fan = self.args.get('fan', str)
        self._computer = self.args.get('computer', str)

        for motion_sensor in self._motion_sensors:
        # Set the turn off computer function
            self.listen_state(
                    self.__off_motion_for_computer,
                    motion_sensor,
                    new='off',
                    old='on',
                    duration=30*60)
            
            self.listen_state(
                    self.__on_motion_for_computer,
                    motion_sensor,
                    new='on',
                    old='off')
       
        # todo override behaviour

    def on_housemode_day(self, old: HouseModes) -> None:
        super().on_housemode_day(old)
        # todo override behaviour
    
    def on_housemode_morning(self, old: HouseModes) -> None:
        super().on_housemode_morning(old)
        # todo override behaviour
    
    def on_housemode_evening(self, old: HouseModes) -> None:
        super().on_housemode_evening(old)
        # todo override behaviour

    def on_housemode_night(self, old: HouseModes) -> None:
        super().on_housemode_night(old)
        # todo override behaviour

    def motion_on_detected(self, entity:str)->None:
        super().motion_on_detected(entity)
        if self.get_state(self._fan) == 'off':
            self.turn_on(self._fan)
        
    def motion_off_detected(self, entity:str)->None:
        super().motion_off_detected(entity)
        if self.get_state(self._fan) == 'on':
            self.turn_off(self._fan)

    def nightlights_off_detected(self, entity:str)->None:
        super().nightlights_off_detected(entity)
        # todo override hehaviour

    def on_lightswich_state_changed(self, entity: str, old: str, new: str)->None:
        super().on_lightswich_state_changed(entity, old, new)
        # todo override hehaviour

    def __on_motion_for_computer(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """callback when motion detected in area"""
        if self.get_state(self._computer) == 'on':
            return # Already on
        self.turn_on(self._computer)
    def __off_motion_for_computer(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """callback motion off in area"""
        if self.get_state(self._computer) == 'off':
            return
        self.turn_off(self._computer)
        
            