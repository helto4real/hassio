"""MyFitnessPalSensor class"""
import aiohttp
import asyncio
import async_timeout
import json
import logging
import datetime
import re

import voluptuous as vol

from typing import Dict

import homeassistant.helpers.config_validation as cv

from homeassistant.components.sensor import PLATFORM_SCHEMA
from homeassistant.config_entries import ConfigEntry
from homeassistant.core import HomeAssistant
from homeassistant.helpers import aiohttp_client
from homeassistant.helpers.entity import Entity
from homeassistant.util import Throttle, slugify
from homeassistant.const import (
    CONF_USERNAME,
    CONF_PASSWORD,
    CONF_NAME,
    STATE_UNAVAILABLE,
    ATTR_ATTRIBUTION,
)

from .const import DOMAIN, ATTRIBUTION, DEFAULT_NAME, SENSOR, ICON
from custom_components.my_fitnesspal.entity import MyFitnessPalEntity


_LOGGER = logging.getLogger(__name__)


async def async_setup_entry(
    hass: HomeAssistant, config_entry: ConfigEntry, async_add_devices
) -> bool:
    """Add a binary_sensor entity from current settings."""

    coordinator = hass.data[DOMAIN][config_entry.entry_id]

    async_add_devices([MyFitnessPalSensor(coordinator, config_entry)])

    return True


class MyFitnessPalSensor(MyFitnessPalEntity):
    @property
    def name(self):
        """Return the name of the sensor."""
        return f"{DEFAULT_NAME}_{self.coordinator.display_name}"

    @property
    def unique_id(self):
        """Return the unique ID of the device."""
        return f"{DEFAULT_NAME}_{self.coordinator.display_name}"

    @property
    def state(self):
        """Return the state of the sensor."""
        if len(self.coordinator.data) > 0:
            return round(
                (
                    self.coordinator.data.get("total_calories")
                    / (
                        self.coordinator.data.get("goal_calories")
                        + self.coordinator.data.get("cardio_calories_burned")
                    )
                )
                * 100,
                0,
            )
        else:
            self._available = False
            return STATE_UNAVAILABLE

    @property
    def icon(self):
        """Return the icon of the sensor."""
        return ICON

    @property
    def unit_of_measurement(self):
        """Return the units of measurement."""
        return "%"
