from enum import Enum
from typing import Tuple, Union

from base import App
from globals import GlobalEvents

"""
    Handles the Xiaomi Magic Cube Events

"""
class XiaomiMagicCubeManager(App):
    
    
    def initialize(self) -> None:
        
        self._cubes = self.args.get('cubes', [])

        self.listen_event(self.__on_cube_changed, 'deconz_event')
    
    def __on_cube_changed(
        self, event_name: str, data: dict, kwargs: dict) -> None:
        self.log(data)
        if data.get('id', 'no_id') in self._cubes:
            event:str = str(data['event'])
            if event.startswith('-'):
                self.fire_event('MAGIC_CUBE_EVENT', event_type='rotate', data='left', id=data['id'])
            else:
                if event[1] != '0':
                    self.fire_event('MAGIC_CUBE_EVENT', event_type='rotate',  data='right', id=data['id'])
                else:
                    if event == '7000':
                        self.fire_event('MAGIC_CUBE_EVENT', event_type='wakeup', id=data['id'])
                    elif event == '7007':
                        self.fire_event('MAGIC_CUBE_EVENT', event_type='shake', id=data['id'])
                    elif event.endswith('0'):
                        self.fire_event('MAGIC_CUBE_EVENT', event_type='drag', id=data['id'])
                    else:
                        self.fire_event('MAGIC_CUBE_EVENT', event_type='flip', id=data['id'])