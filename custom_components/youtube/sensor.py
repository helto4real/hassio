import aiohttp
import asyncio
import async_timeout
import json
import logging
import datetime
import voluptuous as vol
from typing import Dict

from homeassistant.components.sensor import PLATFORM_SCHEMA
from homeassistant.helpers.entity import Entity
from homeassistant.util import Throttle
from homeassistant.helpers import aiohttp_client

_LOGGER = logging.getLogger(__name__)


async def async_setup_platform(hass, config, add_devices, discovery_info=None):
    """Set up the computer switch platform."""
    entities = config.get('entities', {})
    devices = []

    session = aiohttp_client.async_get_clientsession(hass)

    for entity in entities:
        devices.append(YoutubeSensor(hass, session, entity,
                                              entities[entity]['channel_id'],
                                              entities[entity]['key']))

    add_devices(devices, True)


class YoutubeSensor(Entity):
    def __init__(self, hass, session: aiohttp.ClientSession, name: str, channel_id: str,
        key: str) -> None:
        """Initialize the YoutubeSensor entity."""
 
        self._name = "yt_{}".format(name)
        self._channel_id = channel_id
        self._key = key
        self._session = session
        self._available = False
        self._state = 0
        self._attributes: Dict[str, str] = {}
        _LOGGER.info("Init youtube sensor {} with channel_id {}".format(
            self._name, self._channel_id))

    @property
    def should_poll(self):
        """Return the polling state."""
        return True

    @property
    def unique_id(self):
        """Return the unique ID of the device."""
        return self._name

    @property
    def name(self):
        """Return the name of the entity."""
        return self._name

    @property
    def icon(self):
        """Return the icon of the entity."""
        return 'mdi:youtube'

    @property
    def state(self):
        """Return the state of the sensor."""

        return self._state 
    
    @property
    def available(self):
        return self._available

    @property
    def device_state_attributes(self) -> Dict[str, str]:
        """Return the state attributes."""
        return self._attributes

    @Throttle(datetime.timedelta(minutes=5))
    async def async_update(self):
        """Update setting state."""
        try:
            with async_timeout.timeout(30, loop=self.hass.loop):
                await self.get_data()
        except (asyncio.TimeoutError):
            self._available = False
            _LOGGER.error("Timeout fetching recycling data")

    async def get_data(self) -> None:
        api_url = "https://www.googleapis.com/youtube/v3/channels?id={}" \
            "&part=statistics&key={}".format(self._channel_id, self._key)

        async with self._session.get(api_url) as response:
            if response.status != 200:
                _LOGGER.warn("Fail to get Youtube information {}, check key or channel id"
                                .format(self._name))
                self._available = False
                return

            data = await response.text()
            data_json = json.loads(data)

            items = data_json.get("items", [])
            if len(items) == 0:
                _LOGGER.error("Fail to get Youtube information, no items returned for {}, check key or channel id"
                                .format(self._name))
                self._available = False
                return
            stats = items[0].get("statistics", {})
            if len(stats) == 0:
                _LOGGER.error("Fail to get Youtube information, no statistics returned for {}, check key or channel id"
                                .format(self._name))
                self._available = False
                return 
            if stats["hiddenSubscriberCount"] != False:
                _LOGGER.warn("Fail to get Youtube information, subscriber count are hidden!{}, check key or channel id"
                                .format(self._name))
                self._available = False
                return
            
            subscriber_count = int(stats["subscriberCount"])
            video_count = int(stats["videoCount"])
            view_count = int(stats["viewCount"])
            comment_count = int(stats["commentCount"])

            self._state = subscriber_count
            self._attributes["video_count"] = video_count
            self._attributes["view_count"] = view_count
            self._attributes["comment_count"] = comment_count

            self._available = True