from base import Base
from globals import GlobalEvents, presence_state, PEOPLE
from typing import Tuple, Union
import datetime, time
import secrets
"""
Class ProximityManager handles automation depending how far a person are to a zone

Following use-cases are implemented:
- If One or more proximity sensors within a range and specific time of day
  send event

"""
class WelcomeHomeManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class
        self._door_sensor = self.args.get('door_sensor', str)
        self._tts_device = self.args.get('tts_device', str)
        self._was_away = {} # The person needs to be away before can get another announcement

        self.log(self.datetime())
        for person in PEOPLE:
            self.listen_state(
                self.__on_presence_changed, entity=PEOPLE[person]['device_tracker'], attribute='all', person=person)
            self._was_away[person] = True

        self.listen_state(
            self.__on_door_sensor_changed, new='on', old='off', entity=self._door_sensor)

    def __on_door_sensor_changed(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:

        for person in PEOPLE:
            state = self.get_state(PEOPLE[person]['device_tracker'])
            if state == presence_state['just_arrived']:
                self.__announce_welcome_home(person)

    def __on_presence_changed(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        if new['state'] == old['state']:
            return # We dont care about updates in attributes
            
        person = kwargs['person']
        # If the person hast just arrived and the door sensor i just been triggered then
        if new['state'] == presence_state['just_arrived']:
            door_sensor_state = self.get_state(self._door_sensor, attribute='all')
            
            last_changed = self.convert_utc(door_sensor_state.get('last_changed', str))
            time_lapsed = datetime.datetime.now(datetime.timezone.utc) - last_changed
      
            if time_lapsed.days == 0 and time_lapsed.seconds < 60*5: # 5 minutes
                self.__announce_welcome_home(person)

        elif new['state']!=presence_state['just_left'] and new['state']!=presence_state['home']:
            self._was_away[person] = True # We set this to True to be able to announce again

    def __announce_welcome_home(self, person:str)->None:
        if self._was_away[person] is True: # Only persons that been away we announce
            self._was_away[person] = False
            self.__trigger_message(person)
 
    def __trigger_message(self, person:str)->None:
        
        message = secrets.choice(
            [
                "Välkomen hem {} hoppas du haft en fin dag så här långt!".format(person),  
                'Hoppas du haft det bra {}, välkommen hem ska du vara!'.format(person),                
                'Va roligt att du kommer hem nu {}, här är allt lugnt.'.format(person),       
                '{}, hoppas din dag varit bra hittils. Välkommen!'.format(person) 
            ])

        self.tts_manager.set_volume_level('0.9', media_player=self._tts_device)
        self.tts_manager.speak(message, media_player=self._tts_device)