from base import Base
from weather_helper import get_yr_weather_text_from_symbol
from globals import GlobalEvents

"""
Class MorningAnnouncement handles the announcement for Tomas (will make it more general for more people later)

Following features are implemented:

- Greeting
- Current weather
- Current temperature outsider from sensor
- Streaming of latest swedish radio EKO (news)

"""
class MorningAnnouncement(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class
        self._tts_device = self.args['tts_device']
        self._temp_device = self.args['temp_device']

        self.do_morning_announcement()

    def do_morning_announcement(self):
        """do the announcement"""
        # we do all these tts sessions non blocking calls
        self.tts_manager.speak("God morgon Tomas, hoppas du får en fin dag")

        self.run_in(self._speak_weather, 6)       

    def _speak_weather(self, kwargs: dict) -> None:
        
        yr_symbol = self.get_state('sensor.yr_symbol')
        temp = int(round(float(self.get_state(self._temp_device)), 0))
        
        self.tts_manager.speak("Det är {} i Matfors just nu med en temperatur på {} grader".format(get_yr_weather_text_from_symbol(yr_symbol), temp))

        self.run_in(self._stream_swedish_news, 10)       
               

    def _stream_swedish_news(self, kwargs: dict) -> None:
        
        self.fire_event(
            GlobalEvents.APP_SR_PLAY_PROGRAM.value,
            program_id='4540', # dagens eko, swedish news
            entity_id=self._tts_device
        )