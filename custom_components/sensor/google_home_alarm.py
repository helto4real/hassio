from homeassistant.helpers.entity import Entity
import homeassistant.helpers.config_validation as cv
from homeassistant.const import (
    CONF_NAME, CONF_UNIT_OF_MEASUREMENT, CONF_HOST, STATE_UNKNOWN, STATE_ON, STATE_OFF)
from homeassistant.components.sensor import PLATFORM_SCHEMA

import datetime
from urllib.request import urlopen
import json
import voluptuous as vol

DEFAULT_NAME = 'Google home alarm sensor'
ATTR_NEXT_ALARM = 'Next alarm'
TXT_NOT_SET = 'Not set'

PLATFORM_SCHEMA = PLATFORM_SCHEMA.extend({
    vol.Optional(CONF_NAME, default=DEFAULT_NAME): cv.string,
    vol.Required(CONF_HOST): cv.string
})

def setup_platform(hass, config, add_devices, discovery_info=None):
    """Setup the sensor platform."""
    host = config.get(CONF_HOST)
    name = config.get(CONF_NAME)
    add_devices([gh_alarm_sensor(name, host)])

class gh_alarm_sensor(Entity):
    """Representation of a Sensor."""

    def __init__(self, name, host):
        """Initialize the sensor."""
        self._name = name
        self._host = host
        self._state = STATE_OFF
        self._last_known_time_for_alarm = datetime.datetime.max

    @property
    def host(self):
        """Return the host."""
        return self._host

    @property
    def name(self):
        """Return the name of the sensor."""
        return self._name

    @property
    def state(self):
        """Return the state of the sensor."""
        return self._state

    @property
    def unit_of_measurement(self):
        """Return the unit of measurement."""
        return None

    @property
    def device_state_attributes(self):
        
        if self._last_known_time_for_alarm == datetime.datetime.max:
            lk_alarm = TXT_NOT_SET
        else:
            lk_alarm = str(self._last_known_time_for_alarm)
        return {
            ATTR_NEXT_ALARM: lk_alarm
        }
    @property
    def last_known_time_for_alarm(self):
        return self._last_known_time_for_alarm

    def findNextAlarmFromGoogleHomeDevice(self, deviceIp):
 
        try:
            response = urlopen("http://"+deviceIp+":8008/setup/assistant/alarms")
        
            data = response.read().decode('utf-8')
            jsonData = json.loads(data)

            currentAlarm = datetime.datetime.max

            if len(jsonData['alarm']) > 0:
                for item in jsonData['alarm']:
                    test = int(item['fire_time'])
                    timeForAlarm = datetime.datetime.fromtimestamp(test/1000)
                    if timeForAlarm < currentAlarm:
                        currentAlarm = timeForAlarm
            return currentAlarm
        except:
            pass
        
        return None
    
    def update(self):
        # First handle the alarm by checking the last known alarm time.
        # Last know alarm time handles the state so we dont miss an alarm
        # if you turn off the alarm before the device is pulled 
        if self._last_known_time_for_alarm is not None and self._last_known_time_for_alarm < datetime.datetime.now():
            #time expired and it is alarming
            diff = datetime.datetime.now() - self._last_known_time_for_alarm
            if diff.seconds<60: # We set state "on" for one minute
                if (self._state == STATE_ON ):
                    return
                else:
                    self._state = STATE_ON
                    return

        # No alarm going on, make sure we set to off state
        if (self._state == STATE_ON ):
            self._state = STATE_OFF

        alarmtime = self.findNextAlarmFromGoogleHomeDevice(self._host)

        if (alarmtime is not None):
            self._last_known_time_for_alarm = alarmtime
        
            