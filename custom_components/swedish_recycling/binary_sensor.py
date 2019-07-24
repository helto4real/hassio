import aiohttp
import asyncio
import async_timeout
import json
import logging
import datetime
import re

from .api import get_data_from_api

# import voluptuous as vol
from typing import Dict

# from homeassistant.components.sensor import PLATFORM_SCHEMA
from homeassistant.config_entries import ConfigEntry
from homeassistant.core import HomeAssistant
from homeassistant.helpers import aiohttp_client
from homeassistant.helpers.entity import Entity
from homeassistant.util import Throttle, slugify

from .const import DOMAIN, CONF_STATION_ID, CONF_USE_AS_STATE, CONF_NAME, ATTRIBUTION

_LOGGER = logging.getLogger(__name__)


async def async_setup_platform(hass, config, add_devices, discovery_info=None):
    """Set up the computer switch platform."""

    entities = config.get("entities", {})
    devices = []

    session = aiohttp_client.async_get_clientsession(hass)

    for entity in entities:
        devices.append(
            SwedishRecyclingSensor(
                hass,
                session,
                entity,
                entities[entity][CONF_STATION_ID],
                entities[entity][CONF_USE_AS_STATE],
            )
        )

    add_devices(devices, True)


async def async_setup_entry(
    hass: HomeAssistant, config_entry: ConfigEntry, config_entries
) -> bool:
    """Add a binary_sensor entity from current settings."""
    session = aiohttp_client.async_get_clientsession(hass)

    station_id = config_entry.data[CONF_STATION_ID]
    use_as_state = config_entry.data[CONF_USE_AS_STATE]
    name = config_entry.data[CONF_NAME]

    entity = SwedishRecyclingSensor(hass, session, name, station_id, use_as_state)

    config_entries([entity], True)
    return True


class SwedishRecyclingSensor(Entity):
    def __init__(
        self,
        hass,
        session: aiohttp.ClientSession,
        name: str,
        station_id: str,
        use_as_state: str,
    ) -> None:
        """Initialize the ComputerSwitch entity."""

        self._name = "swe_recycling_{}".format(name)
        self._station_id = station_id
        self._use_as_state = use_as_state
        self._session = session
        self._available = False
        self._attributes = {}
        _LOGGER.info(
            "Init Swedish recycling {} with station_id {} and use state {}".format(
                self._name, self._station_id, self._use_as_state
            )
        )

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
        return "mdi:trash-can-outline"

    @property
    def state(self):
        """Return the state of the switch."""

        for attr, value in self._attributes.items():
            if attr.lower() == self._use_as_state.lower():
                if value.date() == datetime.datetime.today().date():
                    return "on"
                else:
                    return "off"

        return "unavailable"

    @property
    def available(self):
        return self._available

    @property
    def device_state_attributes(self) -> Dict[str, str]:
        """Return the state attributes."""
        return self._attributes

    @Throttle(datetime.timedelta(minutes=60))
    async def async_update(self):
        """Update setting state."""
        try:
            with async_timeout.timeout(30, loop=self.hass.loop):
                self._attributes = await self.get_data()

                if self._attributes is not None and len(self._attributes) > 0:
                    self._attributes["attribution"] = ATTRIBUTION
                    self._available = True
                else:
                    self._attributes = {}
                    self._attributes["attribution"] = ATTRIBUTION
                    self._available = False
        except (asyncio.TimeoutError):
            self._available = False
            _LOGGER.error("Timeout fetching recycling data")

    async def get_data(self) -> Dict[str, str]:
        return await get_data_from_api(self._session, self._station_id)

