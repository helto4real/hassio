from base import Base
from globals import GlobalEvents
from weather_helper import get_yr_weather_text_from_symbol

"""
Class MorningAnnouncement handles the announcement for Tomas (will make it more general for more people later)

Following features are implemented:

- Greeting
- Current weather
- Current temperature outside from sensor
- Streaming of latest swedish radio EKO (news)

"""


class MorningAnnouncement(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()  # Always call base class
        
        self._tts_device = self.args['tts_device']
        self._temp_device = self.args['temp_device']

        self.listen_event(
            self.__on_alarm,
            GlobalEvents.EV_ALARM_CLOCK_ALARM.value)

    def do_morning_announcement(self):
        """do the announcement"""
        yr_symbol = self.get_state('sensor.yr_symbol')
        temp = int(round(float(self.get_state(self._temp_device)), 0))

        # we do all these tts sessions non blocking calls
        self.tts_manager.set_volume_level('0.6', media_player=self._tts_device)
        self.tts_manager.speak(
            "God morgon Tomas, hoppas du får en fin dag", media_player=self._tts_device)
        self.tts_manager.speak("Det är {} i Matfors just nu med en temperatur på {} grader".format(
            get_yr_weather_text_from_symbol(yr_symbol), temp), media_player=self._tts_device)
        self.tts_manager.when_tts_done_do(self._stream_swedish_news)

    def _stream_swedish_news(self) -> None:
        """end with stream the latest news and the morning wakeup is complete :) """
        self.fire_event(
            GlobalEvents.CMD_SR_PLAY_PROGRAM.value,
            program_id='4540',  # dagens eko, swedish news
            entity_id=self._tts_device
        )

    def __on_alarm(
            self, event_name: str, data: dict, kwargs: dict) -> None:
        """When alarm is running, make an announcement after 40 seconds"""
        self.run_in(self.__delayed_announcement, 40)

    def __delayed_announcement(self, kwargs: dict) -> None:
        """Delayed announcement callback"""
        self.do_morning_announcement()
