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
        
        self._remote = self.properties.get('remote', str)
        self._toggle_tv_switch = self.properties.get('toggle_tv_switch', str)
        self._toggle_window_ligts_switch = self.properties.get('toggle_window_ligts_switch', str)

        self.log("REMOTE STATE = {}".format( self.get_state(self._remote) ))
        
    def on_lightswich_state_changed(self, entity: str, old: str, new: str)->None:
        super().on_lightswich_state_changed(entity, old, new)
        if entity==self._toggle_window_ligts_switch:
            # turn on/off lights in window
            self.__toogle_window_lights()
        elif entity==self._toggle_tv_switch:
            self.__toogle_tv()

    def motion_on_detected(self, entity:str)->None:
        tv_remote_state = self.get_state(self._remote)
        if tv_remote_state != 'on':
            super().motion_on_detected(entity) # call normal motion detected
            
    def __toogle_tv(self)->None:
        self.toggle(entity_id=self._remote)
    
    def __toogle_window_lights(self)->None:
        self.toggle(entity_id='light.tvnere_fonster')
    