from base import App
from globals import GlobalEvents
import datetime
from urllib.request import urlopen
import json
import voluptuous as vol

"""
Class Alarm checks the google home device after alarm

Following features are implemented:

- Checks alarm if ran
- Sends EVENT 

"""
class Alarm(App):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class
        self._gh_device_ip = self.args['gh_device_ip']

        self.run_minutely(self.__on_every_minute, datetime.time(0, 0, 0))

        self._last_known_time_for_alarm = datetime.datetime.min

    def __on_every_minute(self, kwargs: dict)->None:
        
        # First handle the alarm by checking the last known alarm time.
        # if you turn off the alarm before the device is pulled 
        if self._last_known_time_for_alarm < datetime.datetime.now():
            #time expired and it is alarming
            diff = datetime.datetime.now() - self._last_known_time_for_alarm
            
            if diff.days == 0 and diff.seconds<60: # We set state "on" for one minute
                #send event
                self.fire_event(
                    GlobalEvents.EV_ALARM_CLOCK_ALARM.value
                )
                self.log("ALARM RUNNING!")

        next_alarm = self.__findNextAlarmFromGoogleHomeDevice()
        if next_alarm==datetime.datetime.max or next_alarm < (datetime.datetime.now()-datetime.timedelta(minutes=2)):
            self.__set_sensor_alarm('off')
            self._last_known_time_for_alarm = datetime.datetime.min
            return
        else:
            self.__set_sensor_alarm('on', "{}".format(next_alarm))
            self._last_known_time_for_alarm = next_alarm



    def __set_sensor_alarm(self, state:str, next_alarm:str='Not set')->None:
        attributes = {}
        attributes["next_alarm"] = next_alarm

        self.set_state('sensor.tomas_next_alarm', state=state, attributes=attributes)
 
    def __findNextAlarmFromGoogleHomeDevice(self)->datetime.datetime:
        try:
            #_LOGGER.warn("http://{}:8008/setup/assistant/alarms".format(deviceIp))
            response = urlopen("http://{}:8008/setup/assistant/alarms".format(self._gh_device_ip))

            data = response.read().decode('utf-8')
            jsonData = json.loads(data)

            currentAlarm = datetime.datetime.max

            if len(jsonData['alarm']) > 0:
                for item in jsonData['alarm']:
                    test = int(item['fire_time'])
                    timeForAlarm = datetime.datetime.fromtimestamp(test/1000)
                    if timeForAlarm < currentAlarm: #timeForAlarm > (datetime.datetime.now()-datetime.timedelta(minutes=2)) and 
                        currentAlarm = timeForAlarm
            
        except:
          #  _LOGGER.warn("Error reading:" + sys.exc_info()[0])
            pass
        
        return currentAlarm