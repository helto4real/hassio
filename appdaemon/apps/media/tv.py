from base import Base
import datetime
import time
from typing import Tuple, Union

"""
This app implements the basic functionality for tv/remote/media_player automations

Following use-cases:
- Turn on TV when I start playing on my media player
  it automatically pauses for an amount of time to give the TV
  a chance to turn on and then play again
- Turn off tv if media_player been idle or off for an amout of time
  (I only have chromecast on this TV but if you use it to watch live TV the use-case makes no sense)


"""


class Tv(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

        self._remote = self.args.get('remote', str)
        self._kodi_switch = self.args.get('kodi_switch', str)
        self._media_players = self.args.get('media_players', [])
        self._delay_before_turn_off_tv = int(
        self.properties.get('delay_before_turn_off_tv', 20))*60

        for media_player in self._media_players:
            self.listen_state(
                self.__on_media_player_play,
                entity=media_player,
                new='playing'
            )
            # Both states idle and
            self.listen_state(
                self.__on_media_player_idle_or_off,
                entity=media_player,
                new='idle',
                duration=self._delay_before_turn_off_tv
            )

            self.listen_state(
                self.__on_media_player_idle_or_off,
                entity=media_player,
                new='off',
                duration=self._delay_before_turn_off_tv
            )

        self.listen_state(
            self.__on_remote_activity_changed,
            entity=self._remote,
            attribute='current_activity'
        )

    def __on_remote_activity_changed(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        """called when remote current_activity_changes"""

        # Make sure the switch controlling the RPI with KODI turns on and off
        if new == 'Sätt på dator':
            self.turn_on_device(self._kodi_switch)
        else:
            self.turn_off_device(self._kodi_switch)

    def __on_media_player_idle_or_off(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        """called when media player changes state to 'idle' or 'off'"""
        # Turn off tv when been idle or off for an amout of time
        if old == 'off':
            return  # Can never be from off
  
        self.log("INACTIVITY TV, from state {} to {}".format(old, new))

        if self.__is_media_playing() is True:              # Added check cause sometimes it turns off when playing
            self.log("Media is playing, it is still active!!")
            return

        self.log("Turning off TV due to inactivity")
        self.__turn_off_tv()

    def __on_media_player_play(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        """called when media player changes state to 'playing'"""

        if self.get_state(entity=self._remote) == 'on':
            return  # already on, nothing to do

        # first pause media player to let the TV get som time to turn on
        self.__pause(entity)
        # turn on tv
        self.__turn_on_tv()
        # wait 10 seconds and play again
        self.run_in(self.__delay_play, 20, media_player=entity)

    def __pause(self, entity:str)->None:
        self.call_service('media_player/media_pause',
                          entity_id=entity)

    def __delay_play(self, kwargs: dict)->None:

        self.__play(kwargs['media_player'])

    def __play(self, entity:str)->None:
        self.call_service('media_player/media_play',
                          entity_id=entity)

    def __turn_on_tv(self)->None:
        self.turn_on(entity_id=self._remote)

    def __turn_off_tv(self)->None:
        self.turn_off(entity_id=self._remote)

    def __is_media_playing(self)->bool:
        for media_player in self._media_players:
            if self.get_state(media_player) == 'playing':
                return True
        return False
