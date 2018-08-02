from base import Base
from globals import GlobalEvents, presence_state
from typing import Tuple, Union
from operator import itemgetter
import datetime, time

"""
Class ProximityManager handles automation depending how far a person are to a zone

Following use-cases are implemented:
- If One or more proximity sensors within a range and specific time of day
  send event

"""
class ProximityManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class
        self._devices = self.args.get("devices", {})
        self._dir_of_travel = self.args.get("dir_of_travel", 'towards')
        self._distance = self.args.get("distance", 0)
        self._message = self.args.get("message", 0)
        self._tts_device = self.args.get("tts_device", str)
        self._device_is_near = 'unknown'

        for device in self._devices:
            self.listen_state(
                self.__on_proximity_changed, 
                entity=device,
                attribute="all"
            )

    
    def __on_proximity_changed(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        self.log(entity)
        current_distance = int(new['state'])
        current_direction = new['attributes']['dir_of_travel']
        self.log("Distance: {}km, direction: {}".format(current_distance, current_direction))
        if current_direction == 'towards' and current_distance <= self._distance and self._device_is_near == 'no':
            self._device_is_near = 'yes'
            self.tts_manager.speak(self._message, media_player=self._tts_device)
            self.notification_manager.greeting('Tomas', 'På väg hem', 'Nu är vi på väg hem från jobbet!')
        elif current_distance > self._distance:
            self._device_is_near = 'no'