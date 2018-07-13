from area import Area
from globals import GlobalEvents, HouseModes

'''
A specific superclass of Area as an example of how you could 
superclass Area and work on your own room details

Important to keep the "super()...." to make default area behaviour work

'''
class TVRoom(Area):
    def initialize(self) -> None:
        super().initialize()
        
        self._remote = self.args.get('remote', str)
 
    def on_lightswich_state_changed(self, entity: str, old: str, new: str)->None:
        super().on_lightswich_state_changed(entity, old, new)
        if entity=='switch.switch_1_lb':
            # turn on/off lights in window
            self.__toogle_window_lights()
        elif entity=='switch.switch_1_rb':
            self.__toogle_tv()


    def __toogle_tv(self)->None:
        self.toggle(entity_id=self._remote)
    
    def __toogle_window_lights(self)->None:
        
        self.toggle(entity_id='light.tvnere_fonster')
    