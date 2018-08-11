from area import Area
from globals import GlobalEvents, HouseModes

'''
Implments logic for the master bedroom

'''
class MasterBedroom(Area):
    def initialize(self) -> None:
        super().initialize()
        

    def motion_on_detected(self, entity: str)->None:
        """called when motion off in area"""
        super.motion_on_detected(entity)

    def motion_off_detected(self, entity):
        super.motion_off_detected(entity)
