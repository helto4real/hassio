"""NetDaemon integration."""
import asyncio
from datetime import timedelta
from typing import TYPE_CHECKING

from homeassistant.helpers.update_coordinator import DataUpdateCoordinator

from .api import NetDaemonApi
from .client import NetDaemonClient
from .const import (
    ATTR_CLASS,
    ATTR_CLIENT,
    ATTR_SERVICE,
    ATTR_COORDINATOR,
    ATTR_ENTITY_ID,
    ATTR_METHOD,
    DEFAULT_CLASS,
    DEFAULT_METHOD,
    DOMAIN,
    LOGGER,
    PLATFORMS,
    SERVICE_ENTITY_CREATE,
    SERVICE_ENTITY_REMOVE,
    SERVICE_ENTITY_UPDATE,
    SERVICE_REGISTER_SERVICE,
    SERVICE_RELOAD_APPS,
    STARTUP,
)

if TYPE_CHECKING:
    from homeassistant.config_entries import ConfigEntry
    from homeassistant.core import HomeAssistant


async def async_setup(_hass: "HomeAssistant", _config: dict) -> bool:
    """Set up this integration using yaml."""
    return True


async def async_setup_entry(hass: "HomeAssistant", config_entry: "ConfigEntry") -> bool:
    """Set up this integration using UI."""
    LOGGER.info(STARTUP)
    client = NetDaemonClient(hass)

    async def async_update_data():
        return client.entities

    # Load stored data from .storage/netdaemon
    await client.load()

    coordinator = DataUpdateCoordinator(
        hass,
        LOGGER,
        name=DOMAIN,
        update_method=async_update_data,
        update_interval=timedelta(seconds=360),
    )
    hass.data[DOMAIN] = {ATTR_COORDINATOR: coordinator, ATTR_CLIENT: client}
    await coordinator.async_refresh()

    # Services
    async def handle_register_service(call):
        """Register custom services."""

        service_name = call.data.get(ATTR_SERVICE)
        if not service_name:
            daemon_class = call.data.get(ATTR_CLASS, DEFAULT_CLASS)
            daemon_method = call.data.get(ATTR_METHOD, DEFAULT_METHOD)
            service_name = f"{daemon_class}_{daemon_method}"

        LOGGER.info("Register service %s", service_name)
        hass.services.async_register(
            DOMAIN, service_name, netdaemon_noop
        )

    async def netdaemon_noop(_call):
        """Do nothing for now, the netdaemon subscribes to this service."""

    async def entity_create(call):
        """Create an entity."""
        entity_id = call.data.get(ATTR_ENTITY_ID)
        if not entity_id:
            LOGGER.error("No 'entity_id' for service %s", SERVICE_ENTITY_CREATE)
        if "." not in entity_id:
            LOGGER.error(
                "%s is not a valid entity ID for service %s",
                entity_id,
                SERVICE_ENTITY_CREATE,
            )
        if entity_id.split(".")[0] not in PLATFORMS:
            LOGGER.error(
                "%s is not a valid platform (%s) for service entity_create",
                entity_id.split(".")[0],
                PLATFORMS,
            )

        await client.entity_create(call.data)
        await coordinator.async_refresh()
        await async_reload_entry(hass, config_entry)

    async def entity_update(call):
        """Create an entity."""
        entity_id = call.data.get(ATTR_ENTITY_ID)
        if not entity_id:
            LOGGER.error("No 'entity_id' for service %s", SERVICE_ENTITY_UPDATE)
        if "." not in entity_id:
            LOGGER.error(
                "%s is not a valid entity ID for service %s",
                entity_id,
                SERVICE_ENTITY_UPDATE,
            )
        if entity_id.split(".")[0] not in PLATFORMS:
            LOGGER.error(
                "%s is not a valid platform (%s) for service %s",
                entity_id.split(".")[0],
                PLATFORMS,
                SERVICE_ENTITY_UPDATE,
            )

        await client.entity_update(call.data)
        await coordinator.async_refresh()

    async def entity_remove(call):
        """Create an entity."""
        entity_id = call.data.get(ATTR_ENTITY_ID)
        if not entity_id:
            LOGGER.error("No 'entity_id' for service %s", SERVICE_ENTITY_REMOVE)
        if "." not in entity_id:
            LOGGER.error(
                "%s is not a valid entity ID for service %s",
                entity_id,
                SERVICE_ENTITY_REMOVE,
            )
        if entity_id.split(".")[0] not in PLATFORMS:
            LOGGER.error(
                "%s is not a valid platform (%s) for service %s",
                entity_id.split(".")[0],
                PLATFORMS,
                SERVICE_ENTITY_REMOVE,
            )
        await client.entity_remove(call.data)
        await coordinator.async_refresh()

    hass.services.async_register(
        DOMAIN, SERVICE_REGISTER_SERVICE, handle_register_service
    )
    hass.services.async_register(DOMAIN, SERVICE_RELOAD_APPS, netdaemon_noop)
    hass.services.async_register(DOMAIN, SERVICE_ENTITY_CREATE, entity_create)
    hass.services.async_register(DOMAIN, SERVICE_ENTITY_UPDATE, entity_update)
    hass.services.async_register(DOMAIN, SERVICE_ENTITY_REMOVE, entity_remove)

    # Platforms
    for platform in PLATFORMS:
        LOGGER.debug("Adding platfrom %s", platform)
        hass.async_add_job(
            hass.config_entries.async_forward_entry_setup(config_entry, platform)
        )

    config_entry.add_update_listener(async_reload_entry)

    # API
    hass.http.register_view(NetDaemonApi())
    return True


async def async_unload_entry(hass: "HomeAssistant", entry: "ConfigEntry") -> bool:
    """Handle removal of an entry."""
    unloaded = False
    if str(entry.state) in ["ConfigEntryState.LOADED", "loaded"]:
        unloaded = all(
            await asyncio.gather(
                *[
                    hass.config_entries.async_forward_entry_unload(entry, platform)
                    for platform in PLATFORMS
                ]
            )
        )
    if unloaded:
        del hass.data[DOMAIN]

    return unloaded


async def async_remove_entry(
    hass: "HomeAssistant", _config_entry: "ConfigEntry"
) -> None:
    """Handle removal of an entry."""
    await NetDaemonClient(hass).clear_storage()


async def async_reload_entry(
    hass: "HomeAssistant", config_entry: "ConfigEntry"
) -> None:
    """Reload the config entry."""
    await async_unload_entry(hass, config_entry)
    await async_setup_entry(hass, config_entry)
