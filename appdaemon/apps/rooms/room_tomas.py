from area import Area
from globals import GlobalEvents, HouseModes, presence_state
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
        self._tracker = self.args.get('tracker', str)

        self.register_constraint("constraint_tomas_is_home")
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
                    old='off',
                    constraint_tomas_is_home=1)
       
        
    def constraint_tomas_is_home(self, value) -> bool:    
        if self.get_state(self._tracker) == presence_state["home"]:
            return True
        else:
            return False

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
        if self.get_state(self._computer) == 'off':
            self.turn_on(self._computer) # Turn on computer if it is off

    def __off_motion_for_computer(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """callback motion off in area"""
        if self.get_state(self._computer) == 'on':
            self.turn_off(self._computer) # Turn off computer if its on
        
            