"""Select platform for NetDaemon."""
from typing import TYPE_CHECKING

from homeassistant.components.select import SelectEntity

from .const import (
    ATTR_CLIENT,
    ATTR_COORDINATOR,
    ATTR_ENTITY_ID,
    ATTR_STATE,
    ATTR_OPTIONS,
    DOMAIN,
    LOGGER,
    PLATFORM_SELECT,
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
    """Setup select platform."""
    client: "NetDaemonClient" = hass.data[DOMAIN][ATTR_CLIENT]
    coordinator: "DataUpdateCoordinator" = hass.data[DOMAIN][ATTR_COORDINATOR]

    selects = []
    for entity in client.entities:
        if entity.split(".")[0] == PLATFORM_SELECT:
            LOGGER.debug("Adding %s", entity)
            selects.append(
                NetDaemonSelect(coordinator, entity.split(".")[1])
            )

    if selects:
        async_add_devices(selects)


class NetDaemonSelect(NetDaemonEntity, SelectEntity):
    """NetDaemon select class."""

    @property
    def current_option(self):
        """Return the state of the select."""
        if not self.entity_id:
            return None
        state = str(self._coordinator.data[self.entity_id][ATTR_STATE])
        return state

    @property
    def options(self):
        """Return the list of available options."""
        if not self.entity_id:
            return None
        return self._coordinator.data[self.entity_id][ATTR_OPTIONS]

    async def async_select_option(self, option: str) -> None:
        """Change the selected option."""
        await self.hass.data[DOMAIN][ATTR_CLIENT].entity_update(
            {ATTR_ENTITY_ID: self.entity_id, ATTR_STATE: option}
        )
        self.async_write_ha_state()
