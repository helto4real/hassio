from homeassistant.components.switch import SwitchDevice, PLATFORM_SCHEMA
import logging
from urllib.request import urlopen
import uuid
import struct, socket
import voluptuous as vol
import datetime

"""
Custom switch to controll on/off of your computer. 
Following features:

- turns on computer using wake-on-lan (hass implementation)
- turns off computer using the component, sleep-on-lan see https://github.com/SR-G/sleep-on-lan

configure: with the mac and ip of the computer

switch:
  - platform: computer
    entities:
      name1:
          mac: '14:30:2b:1f:39:2e'
          ip: '192.168.0.2'
      name2:
          mac: '64:d1:22:9f:34:1e'
          ip: '192.168.0.2'
"""

_LOGGER = logging.getLogger(__name__)

REQUIREMENTS = ['wakeonlan==1.0.0']

def setup_platform(hass, config, add_devices, discovery_info=None):
    """Set up the ZigBee switch platform."""
    entities = config.get('entities', {})
    devices = []

    for entity in entities:
        devices.append(ComputerSwitch(hass, entity, entities[entity]['ip'], entities[entity]['mac']))
    
    add_devices(devices)

class ComputerSwitch(SwitchDevice):
    """Representation of a computer device (on/off)."""
    def __init__(self, hass, name:str, ip:str, mac:str):
        """Initialize the ComputerSwitch entity."""
        # use wakeonlan package
        import wakeonlan

        self._name = "computer_{}".format(name)
        self._ip = ip
        self._mac = mac
       
        _LOGGER.info("INIT DEVICE {} with ip {} and mac {}".format(self._name, self._ip, self._mac))

        if self.__computer_is_on():
            self._state = 'on'
        else:
            self._state = 'off'

        self._time_to_check = datetime.datetime.min
        self._wol = wakeonlan
    @property
    def should_poll(self):
        """Return the polling state."""
        return True

    @property
    def unique_id(self):
        """Return the unique ID of the device."""
        return "{}-cp".format(self._mac)

    @property
    def name(self):
        """Return the name of the entity."""
        return self._name

    @property
    def icon(self):
        """Return the icon of the entity."""
        return 'mdi:laptop'

    @property
    def is_on(self):
        """Return true if the device is on."""
        if self._state == 'on':
            return True
        else:
            return False

    @property
    def state(self):
        """Return the state of the switch."""
        return self._state

    def update(self):
        """Update setting state."""

        diff = datetime.datetime.now() - self._time_to_check
        if diff.days == 0 and diff.seconds<30:
            return # not ready to update state yet, aim for about once a minute
        self._time_to_check = datetime.datetime.now()

        if self.__computer_is_on():
            self._state = 'on'
        else:
            self._state = 'off'


    def turn_on(self, **kwargs):
        """Turn the computer on."""
        if self.__computer_is_on():
            return #Already awake

        self._time_to_check = datetime.datetime.min # make sure it reads status next update
        self._state = 'on'
        self.__turn_on_computer()


    def turn_off(self, **kwargs):
        """Turn the computer off."""

        if self.__computer_is_on()==False:
            return #Already awake
        self._time_to_check = datetime.datetime.min
        self._state = 'off'
        self.__turn_off_computer()
    
        # todo fix the code here later to call the webservice to hibernate computer

    def __computer_is_on(self)->bool:
        try:
            response = urlopen("http://{}:8009".format(self._ip), timeout=1)
            return True
        except:
            return False #not available som computer is not on
    
    def __turn_on_computer(self)->None:
        
        # Turn on the computer to wake up on lan
        self._wol.send_magic_packet(self._mac)

    def __turn_off_computer(self)->None:
        # Turn off the computer using utility "sleeponlan" https://github.com/SR-G/sleep-on-lan
        response = urlopen("http://{}:8009/sleep".format(self._ip))

    