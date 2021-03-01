"""Sensor platform for NetDaemon."""
from typing import TYPE_CHECKING

from .const import (
    ATTR_CLIENT,
    ATTR_COORDINATOR,
    ATTR_STATE,
    DOMAIN,
    LOGGER,
    PLATFORM_SENSOR,
)
from .entity import NetDaemonEntity

if TYPE_CHECKING:
    from homeassistant.config_entries import ConfigEntry
    from homeassistant.core import HomeAssistant
    from homeassistant.helpers.update_coordinator import DataUpdateCoordinator

    from .client import NetDaemonClient


async def async_setup_entry(
    hass: "HomeAssistant", _config_entry: "ConfigEntry", async_add_devices
) -> None:
    """Setup sensor platform."""
    client: "NetDaemonClient" = hass.data[DOMAIN][ATTR_CLIENT]
    coordinator: "DataUpdateCoordinator" = hass.data[DOMAIN][ATTR_COORDINATOR]

    sensors = []
    for entity in client.entities:
        if entity.split(".")[0] == PLATFORM_SENSOR:
            LOGGER.debug("Adding %s", entity)
            sensors.append(NetDaemonSensor(coordinator, entity.split(".")[1]))

    if sensors:
        async_add_devices(sensors)


class NetDaemonSensor(NetDaemonEntity):
    """NetDaemon Sensor class."""

    @property
    def state(self):
        """Return the state of the sensor."""
        return self._coordinator.data[self.entity_id][ATTR_STATE]
