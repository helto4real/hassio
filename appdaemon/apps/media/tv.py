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
        self._cube = self.args.get('cube', str)
        self._kodi_switch = self.args.get('kodi_switch', str)
        self._media_players = self.args.get('media_players', [])
        self._delay_before_turn_off_tv = int(
        self.properties.get('delay_before_turn_off_tv', 20))*60
        self._tv_ambient_light = self.properties.get('tv_ambient_light', str)

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

        self.listen_event(self.__on_cube_changed, 'MAGIC_CUBE_EVENT')


    def __on_cube_changed(
        self, event_name: str, data: dict, kwargs: dict) -> None:
    
        if data['id'] != self._cube:
            return # Not correct cube

        if data['event_type'] == 'flip':
            self.__toggle_pause_play_media()
        elif data['event_type'] == 'shake':
            self.__turn_off_tv()
        elif data['event_type'] == 'rotate':
            if data['data'] == 'left':
                self.__volume_down()
            else:
                self.__volume_up()
   
    def __on_remote_activity_changed(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        """called when remote current_activity_changes"""

        self.log_to_logbook('TV', "Ny state  {}".format(new))

        # Make sure the switch controlling the RPI with KODI turns on and off
        if new == 'Film':
            
            self.turn_on_device(self._kodi_switch)
        else:
            self.turn_off_device(self._kodi_switch)

        if new == 'PowerOff':
            self.__stop_all_media()
            self.turn_off_device(self._tv_ambient_light)
        else:
            self.turn_on_device(self._tv_ambient_light)

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
        self.log_to_logbook('TV', "Stänger av TV pga inaktivitet")
        self.log("Turning off TV due to inactivity")
        self.__turn_off_tv()

    def __on_media_player_play(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        """called when media player changes state to 'playing'"""

        if self.get_state(entity=self._remote) == 'on':
            return  # already on, nothing to do

        self.log_to_logbook('TV', "Slår på  {}".format(entity))

        # First pause media player to let the TV get som time to turn on
        self.__pause(entity)
        self.log_to_logbook('TV', "Pausar  {}".format(entity))
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
        self.log_to_logbook('TV', "Spelar  {}".format(entity))

    def __turn_on_tv(self)->None:
        self.turn_on(entity_id=self._remote)

    def __turn_off_tv(self)->None:
        self.turn_off(entity_id=self._remote)

    def __is_media_playing(self)->bool:
        for media_player in self._media_players:
            if self.get_state(media_player) == 'playing':
                return True
        return False

    def __stop_all_media(self)->None:
        for media_player in self._media_players:
            self.call_service('media_player/media_stop',
                          entity_id=media_player)

    def __toggle_pause_play_media(self)->None:
        for media_player in self._media_players:
            state = self.get_state(media_player)
            if state == 'playing':
                self.__pause(media_player)
            elif state == 'paused':
                self.__play(media_player)

    def __volume_up(self)->None:
        self.log_to_logbook('TV', "Ökar volymen")
        self.call_service('remote/send_command', entity_id=self._remote, device=14329974, command='VolumeUp', num_repeats=10, delay_secs=0.05)

    def __volume_down(self)->None:
        self.log_to_logbook('TV', "Minskar volymen")
        self.call_service('remote/send_command', entity_id=self._remote, device=14329974, command='VolumeDown', num_repeats=10, delay_secs=0.05)
