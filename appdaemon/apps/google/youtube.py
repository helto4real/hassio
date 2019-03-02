from base import Base
from globals import PEOPLE
from typing import Tuple, Union
"""
Class YoutubeManager manages the TTS announcement for subscriber counts


"""
class YoutubeManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class

        self._person = self.args.get("person", "")
        self._youtube_sensor = self.args.get("youtube_sensor", "")
        self._tts_device = self.args.get("tts_device", "media_player.house")
        self._device_tracker = PEOPLE[self._person]['device_tracker']

        self.listen_state(
            self.__on_yt_sensor_changed, 
            entity=self._youtube_sensor
        )

    def __on_yt_sensor_changed(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:

        if old == new or not self.now_is_between("07:00:00", "22:30:00"):
            return

        self.tts_manager.speak("Nu kommer det nyheter.", media_player=self._tts_device)

        if old<new:
            self.tts_manager.speak("{}, Nyheter om din youtube kanal!." \
                "Grattis du har nu ökat prenumeranter till {} !".format(self._person, new),
                media_player=self._tts_device)
        else:
            self.tts_manager.speak("{}, Nyheter om din youtube kanal!" \
                "Tråkiga nyheter, har nu minskat prenumeranter till {} !".format(self._person, new),
                media_player=self._tts_device)
