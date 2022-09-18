"""Binary sensor platform for NetDaemon."""
from typing import TYPE_CHECKING

from homeassistant.components.binary_sensor import BinarySensorEntity

from .const import (
    ATTR_CLIENT,
    ATTR_COORDINATOR,
    ATTR_STATE,
    DOMAIN,
    LOGGER,
    PLATFORM_BINARY_SENSOR,
    STATE_ON_VALUES,
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
    """Setup binary sensor platform."""
    client: "NetDaemonClient" = hass.data[DOMAIN][ATTR_CLIENT]
    coordinator: "DataUpdateCoordinator" = hass.data[DOMAIN][ATTR_COORDINATOR]

    binary_sensors = []
    for entity in client.entities:
        if entity.split(".")[0] == PLATFORM_BINARY_SENSOR:
            LOGGER.debug("Adding %s", entity)
            binary_sensors.append(
                NetDaemonBinarySensor(coordinator, entity.split(".")[1])
            )

    if binary_sensors:
        async_add_devices(binary_sensors)


class NetDaemonBinarySensor(NetDaemonEntity, BinarySensorEntity):
    """NetDaemon Binary sensor class."""

    @property
    def is_on(self):
        """Return the state of the switch."""
        state = str(self._data_point(ATTR_STATE)).lower()
        return state in STATE_ON_VALUES
