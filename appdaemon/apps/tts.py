from base import Base
from globals import PEOPLE
from globals import HouseModes
import secrets

"""
Class TTManager handles sending text to speech messages to media players

Following features are implemented:

- Speak text to choosen media_player
- Speak text with greeting to choosen media_player

"""
class TTSManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class

    def _calculate_ending_duration_cb(self, kwargs: dict) -> None:
        """Calculate how long the TTS should play before calling cleanup code."""
        media_player = kwargs['media_player']

        duration = self.get_state(
            str(media_player), attribute='media_duration')

        if not duration:
            self.error("Couldn't calculate ending duration for TTS")
            duration = 2

        self.log("DURATION={}".format(duration))
        self.run_in(
            self._end_cb, duration, media_player=media_player)

    def _end_cb(self, kwargs: dict) -> None:
        """do nothing just a wait function. expand later to restore playing media players"""
        media_player = kwargs['media_player']

    def _speak_cb(self, kwargs: dict) -> None:
        """Restore the Sonos to its previous state after speech is done."""
        media_player = kwargs['media_player']
        text = kwargs['text']

        self.call_service(
            'tts/google_say',
            entity_id=str(media_player),
            message=text)

        self.run_in(
            self._calculate_ending_duration_cb,
            2,
            media_player=media_player)        

    
    def speak(self, text: str, media_player:str='media_player.vardagsrum') -> None:
        """Speak the provided text through the media player"""

        # Todo: implement logic to pause on-going media etc. and save state

        self.log('Speaking over TTS: {0}'.format(text))

        self.run_in(
            self._speak_cb,
            3.25,
            media_player=media_player,
            text=text)

    def speak_greeting(self, person:str, message:str, media_player:str='media_player.vardagsrum')->None:
        self.speak(self.notification_manager.greeting_text(person, message), media_player)
