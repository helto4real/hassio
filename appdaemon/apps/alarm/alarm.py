import datetime
import json
from urllib.request import urlopen

import voluptuous as vol

from base import App
from globals import GlobalEvents


"""
Class Alarm checks the google home device if alarm set and sends event if alarm alarming

Following features are implemented:
- Checks if alarm is set and creates sensor for next alarm time
- Checks alarm if ran
- Sends EVENT 

"""


class Alarm(App):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()  # Always call base class
        self._gh_device_ip = self.args['gh_device_ip']

        self.run_minutely(self.__on_every_minute, datetime.time(0, 0, 0))

        self._last_known_time_for_alarm = datetime.datetime.min

    def __on_every_minute(self, kwargs: dict)->None:

        # First handle the alarm by checking the last known alarm time.
        # if you turn off the alarm before the device is pulled
        if self._last_known_time_for_alarm < datetime.datetime.now():
            # time expired and it is alarming
            diff = datetime.datetime.now() - self._last_known_time_for_alarm

            if diff.days == 0 and diff.seconds < 60:  # We set state "on" for one minute
                # send event
                self.fire_event(
                    GlobalEvents.EV_ALARM_CLOCK_ALARM.value
                )
                self.log("ALARM RUNNING!")

        next_alarm = self.__findNextAlarmFromGoogleHomeDevice()
        if next_alarm == datetime.datetime.max:
            self.__set_sensor_alarm('off')
            self._last_known_time_for_alarm = datetime.datetime.min
            return
        else:
            self.__set_sensor_alarm('on', "{}".format(next_alarm))
            self._last_known_time_for_alarm = next_alarm

    def __set_sensor_alarm(self, state: str, next_alarm: str='Not set') -> None:
        attributes = {}
        attributes["next_alarm"] = next_alarm

        self.set_state('sensor.tomas_next_alarm',
                       state=state, attributes=attributes)

    def __findNextAlarmFromGoogleHomeDevice(self)->datetime.datetime:
        try:
            response = urlopen(
                "http://{}:8008/setup/assistant/alarms".format(self._gh_device_ip))

            data = response.read().decode('utf-8')
            jsonData = json.loads(data)

            current_alarm = datetime.datetime.max

            for item in jsonData.get('alarm', []):
                fire_time = int(item['fire_time'])
                status = int(item["status"])
                time_for_alarm = datetime.datetime.fromtimestamp(
                    fire_time/1000)
                if time_for_alarm < current_alarm and status >= 1 and time_for_alarm >= datetime.datetime.now() :
                    current_alarm = time_for_alarm

        except:
          #  _LOGGER.warn("Error reading:" + sys.exc_info()[0])
            pass

        return current_alarm
