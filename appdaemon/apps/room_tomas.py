from area import Area
from globals import GlobalEvents, HouseModes

'''
A specific superclass of Area as an example

'''
class TomasRoom(Area):
    def initialize(self) -> None:
        super().initialize()

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

