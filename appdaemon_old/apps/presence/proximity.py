from base import Base
from globals import GlobalEvents, presence_state, PEOPLE
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
        self._people_to_track = self.args.get("people_to_track", {})
        self._dir_of_travel = self.args.get("dir_of_travel", 'towards')
        self._distance = self.args.get("distance", 0)
        self._message = self.args.get("message", 0)
        self._tts_device = self.args.get("tts_device", str)
        self._device_is_near = {}

        for person in self._people_to_track:

            self.listen_state(
                self.__on_proximity_changed, 
                entity=PEOPLE[person]['proximity'],
                attribute="all",
                person=person
            )
            self._device_is_near[person] = 'yes' # set to yes to avoid false positives when restarted the app

    
    def __on_proximity_changed(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        current_distance = int(new['state'])
        current_direction = new['attributes']['dir_of_travel']
        person = kwargs['person']

        if current_direction == 'towards' and current_distance <= self._distance and self._device_is_near[person] == 'no':
            self._device_is_near[person] = 'yes'
            self.tts_manager.speak("Ett meddelande", media_player=self._tts_device)
            self.tts_manager.speak("{} {}".format(person, self._message), media_player=self._tts_device)
            self.notification_manager.greeting('Tomas', 'På väg hem', "{} {}".format(person, self._message))
        elif current_distance > self._distance:
            self._device_is_near[person] = 'no'
