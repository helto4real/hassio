from area import Area
from globals import GlobalEvents, HouseModes

'''
A specific superclass of Area as an example of how you could 
superclass Area and work on your own room details

Important to keep the "super()...." to make default area behaviour work

'''
class TomasRoom(Area):
    def initialize(self) -> None:
        super().initialize()
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
        super().on_motion_detected(entity)
        # todo override hehaviour

    def off_motion_detected(self, entity:str)->None:
        super().off_motion_detected(entity)
        # todo override hehaviour

    def nightlights_off_detected(self, entity:str)->None:
        super().nightlights_off_detected(entity)
        # todo override hehaviour

    def on_lightswich_state_changed(self, entity: str, old: str, new: str)->None:
        super().on_lightswich_state_changed(entity, old, new)
        # todo override hehaviour