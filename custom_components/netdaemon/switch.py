"""Switch platform for NetDaemon."""
from typing import TYPE_CHECKING

from homeassistant.components.switch import SwitchEntity

from .const import (
    ATTR_CLIENT,
    ATTR_COORDINATOR,
    ATTR_ENTITY_ID,
    ATTR_STATE,
    DOMAIN,
    LOGGER,
    PLATFORM_SWITCH,
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
    """Setup switch platform."""
    client: "NetDaemonClient" = hass.data[DOMAIN][ATTR_CLIENT]
    coordinator: "DataUpdateCoordinator" = hass.data[DOMAIN][ATTR_COORDINATOR]

    switches = []
    for entity in client.entities:
        if entity.split(".")[0] == PLATFORM_SWITCH:
            LOGGER.debug("Adding %s", entity)
            switches.append(NetDaemonSwitch(coordinator, entity.split(".")[1]))

    if switches:
        async_add_devices(switches)


class NetDaemonSwitch(NetDaemonEntity, SwitchEntity):
    """NetDaemon Switch class."""

    @property
    def is_on(self):
        """Return the state of the switch."""
        state = str(self._coordinator.data[self.entity_id][ATTR_STATE]).lower()
        return state in ["true", "on", "1"]

    async def async_turn_on(self, **kwargs):
        """Turn the device on."""
        await self._async_toggle()

    async def async_turn_off(self, **kwargs):
        """Turn the device off."""
        await self._async_toggle()

    async def _async_toggle(self) -> None:
        """Toggle the switch entity."""
        current = self._coordinator.data[self.entity_id][ATTR_STATE]
        await self.hass.data[DOMAIN][ATTR_CLIENT].entity_update(
            {ATTR_ENTITY_ID: self.entity_id, ATTR_STATE: not current}
        )
        self.async_write_ha_state()
