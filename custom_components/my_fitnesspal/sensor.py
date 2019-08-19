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

from .const import DOMAIN, ATTRIBUTION

_LOGGER = logging.getLogger(__name__)

PLATFORM_SCHEMA = PLATFORM_SCHEMA.extend(
    {
        vol.Required(CONF_USERNAME): cv.string,
        vol.Required(CONF_PASSWORD): cv.string,
        vol.Optional(CONF_NAME, default=""): cv.string,
    }
)


async def async_setup_platform(hass, config, add_devices, discovery_info=None):
    """Set up the computer switch platform."""

    name = config.get("name")
    username = config.get("username")
    password = config.get("password")

    if len(name) == 0:
        name = username

    devices = []

    devices.append(MyFitnessPalSensor(hass, name, username, password))
    add_devices(devices, True)


async def async_setup_entry(
    hass: HomeAssistant, config_entry: ConfigEntry, config_entries
) -> bool:
    """Add a binary_sensor entity from current settings."""

    fitness_sensor = MyFitnessPalSensor(
        hass,
        config_entry.data[CONF_NAME],
        config_entry.data[CONF_USERNAME],
        config_entry.data[CONF_PASSWORD],
    )

    config_entries([fitness_sensor], True)
    return True


class MyFitnessPalSensor(Entity):
    def __init__(self, hass, name: str, username: str, password: str) -> None:
        """Initialize the ComputerSwitch entity."""
        self._hass = hass
        self._name = "myfitnesspal_{}".format(name)
        self._username = username
        self._password = password
        self._available = False
        self._attributes = {}
        _LOGGER.info("Init myfitnesspal for user {}".format(self._name))

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
        return "mdi:run-fast"

    @property
    def unit_of_measurement(self):
        """Return the units of measurement."""
        return "%"

    @property
    def state(self):
        """Return the state of the switch."""

        if len(self._attributes) > 0:
            return round(
                (
                    self._attributes["total_calories"]
                    / (
                        self._attributes["goal_calories"]
                        + self._attributes["cardio_calories_burned"]
                    )
                )
                * 100,
                0,
            )
        else:
            self._available = False
            return STATE_UNAVAILABLE

    @property
    def available(self):
        return self._available

    @property
    def device_state_attributes(self) -> Dict[str, str]:
        """Return the state attributes."""
        return self._attributes

    @Throttle(datetime.timedelta(minutes=15))
    async def async_update(self):
        """Update setting state."""
        self._attributes = await self._hass.async_add_executor_job(
            self.update_data_sync
        )  # Sadly only sync functions

        if len(self._attributes) > 0:
            self._attributes[ATTR_ATTRIBUTION] = ATTRIBUTION
            self._available = True
        else:
            self._attributes = {}
            self._available = False

    def update_data_sync(self) -> Dict[str, str]:
        """Get the actual data from the API"""
        import myfitnesspal as ext_myfitnesspal

        today = datetime.date.today()

        client = ext_myfitnesspal.Client(self._username, self._password)
        info = client.get_date(today.year, today.month, today.day)
        weights = client.get_measurements("Weight")

        goal_calories = info.goals.get("calories", 0)
        goal_carbohydrates = info.goals.get("carbohydrates", 0)
        goal_fat = info.goals.get("fat", 0)
        goal_sodium = info.goals.get("sodium", 0)
        goal_sugar = info.goals.get("sugar", 0)
        goal_protein = info.goals.get("protein", 0)

        total_calories = info.totals.get("calories", 0)
        total_carbohydrates = info.totals.get("carbohydrates", 0)
        total_fat = info.totals.get("fat", 0)
        total_sodium = info.totals.get("sodium", 0)
        total_sugar = info.totals.get("sugar", 0)
        total_protein = info.totals.get("protein", 0)
        water = info.water
        _, weight = list(weights.items())[0] if len(weights) > 0 else 0

        cardio_calories_burned = 0
        for exercise in info.exercises[0]:
            cardio_calories_burned += exercise["calories burned"]

        result = {}

        result["goal_calories"] = goal_calories
        result["goal_carbohydrates"] = goal_carbohydrates
        result["goal_fat"] = goal_fat
        result["goal_sodium"] = goal_sodium
        result["goal_sugar"] = goal_sugar
        result["goal_protein"] = goal_protein

        result["total_calories"] = total_calories
        result["total_carbohydrates"] = total_carbohydrates
        result["total_fat"] = total_fat
        result["total_sodium"] = total_sodium
        result["total_sugar"] = total_sugar
        result["total_protein"] = total_protein

        result["cardio_calories_burned"] = cardio_calories_burned
        result["water"] = water
        result["weight"] = weight

        return result

