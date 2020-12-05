import asyncio
import datetime
import logging
import struct
import socket
import time
import uuid

import aiohttp
import async_timeout
#import voluptuous as vol

from homeassistant.components.switch import SwitchEntity
from homeassistant.helpers import aiohttp_client
from homeassistant.util import Throttle
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

#REQUIREMENTS = ['wakeonlan==1.0.0']


async def async_setup_platform(hass, config, add_devices, discovery_info=None):
    """Set up the computer switch platform."""
    _LOGGER.error("ADDING COMPUTER DEVICE!")
    entities = config.get('entities', {})
    devices = []

    session = aiohttp_client.async_get_clientsession(hass)

    for entity in entities:
        devices.append(ComputerSwitch(hass, session, entity,
                                      entities[entity]['ip'], entities[entity]['mac']))

    
    add_devices(devices, True)


class ComputerSwitch(SwitchEntity):
    """Representation of a computer device (on/off)."""

    def __init__(self, hass, session: aiohttp.ClientSession, name: str, ip: str, mac: str):
        """Initialize the ComputerSwitch entity."""
        # use wakeonlan package
        import wakeonlan

        self._name = "computer_{}".format(name)
        self._ip = ip
        self._mac = mac
        self._session = session
        self._wol = wakeonlan
        _LOGGER.info("INIT DEVICE {} with ip {} and mac {}".format(
            self._name, self._ip, self._mac))

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

    @Throttle(datetime.timedelta(seconds=10))
    async def async_update(self):
        """Update setting state."""
        try:
            with async_timeout.timeout(1, loop=self.hass.loop):
                if await self.__computer_is_on():
                    self._state = 'on'
                else:
                    self._state = 'off'
        except (asyncio.TimeoutError):
            self._state = 'off'

    def turn_on(self, **kwargs):
        """Turn the computer on."""
        if self.is_on:
            return  # Already awake

        self._state = 'on'
        self.__turn_on_computer()

    async def async_turn_off(self, **kwargs):
        """Turn the computer off."""

        if not self.is_on:
            return  # Already awake

        self._state = 'off'
        return await self.__turn_off_computer()

    async def __computer_is_on(self)->bool:
        try:
            async with self._session.get("http://{}:8009".format(self._ip)) as response:
                if response.status != 200:
                    return False
            return True
        except:
            return False  # not available som computer is not on

    def __turn_on_computer(self)->None:

        # Turn on the computer to wake up on lan
        self._wol.send_magic_packet(self._mac)

    async def __turn_off_computer(self)->None:
        # Turn off the computer using utility "sleeponlan" https://github.com/SR-G/sleep-on-lan
        try:
            await self._session.get("http://{}:8009/sleep".format(self._ip))
        except:
            pass
