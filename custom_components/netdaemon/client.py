"""NetDaemon class."""
from typing import TYPE_CHECKING, List

from homeassistant.helpers import entity_registry
from homeassistant.helpers.json import JSONEncoder
from homeassistant.helpers.storage import Store

from .const import (
    ATTR_ATTRIBUTES,
    ATTR_ENTITY_ID,
    ATTR_ICON,
    ATTR_STATE,
    ATTR_UNIT,
    LOGGER,
    STORAGE_VERSION,
)

if TYPE_CHECKING:
    from homeassistant.core import HomeAssistant


class NetDaemonClient:
    """NetDaemon class."""

    def __init__(self, hass: "HomeAssistant") -> None:
        """Initialize the NetDaemon class."""
        self.hass = hass
        self._entities: dict = {}
        self.store = Store(hass, STORAGE_VERSION, "netdaemon", encoder=JSONEncoder)

    @property
    def entities(self) -> List[str]:
        """Return a list of entities."""
        return self._entities

    async def load(self) -> None:
        """Load stored data."""
        restored = await self.store.async_load()
        self._entities = restored if restored else {}

    async def clear_storage(self) -> None:
        """Clear storage."""
        await self.store.async_remove()

    async def entity_create(self, data) -> None:
        """Create an entity."""
        LOGGER.info("Creating entity %s", data)
        if data["entity_id"] in self._entities:
            del self._entities[data["entity_id"]]

        self._entities[data[ATTR_ENTITY_ID]] = {
            ATTR_STATE: data.get(ATTR_STATE),
            ATTR_ICON: data.get(ATTR_ICON),
            ATTR_UNIT: data.get(ATTR_UNIT),
            ATTR_ATTRIBUTES: data.get(ATTR_ATTRIBUTES, {}),
        }
        await self.store.async_save(self._entities)

    async def entity_update(self, data) -> None:
        """Update an entity."""
        entity_id = data[ATTR_ENTITY_ID]
        if entity_id not in self._entities:
            LOGGER.error("Entity ID %s is not managed by the netdaemon integration", entity_id)
            return
        self._entities[entity_id].update(data)
        await self.store.async_save(self._entities)

    async def entity_remove(self, data) -> None:
        """Remove an entity."""
        entity_id = data[ATTR_ENTITY_ID]
        if entity_id not in self._entities:
            LOGGER.error("Entity ID %s is not managed by the netdaemon integration", entity_id)
            return
        LOGGER.info("Removing entity %s", entity_id)
        del self._entities[data[ATTR_ENTITY_ID]]
        registry: entity_registry.EntityRegistry = (
            await entity_registry.async_get_registry(self.hass)
        )
        if data[ATTR_ENTITY_ID] in registry.entities:
            registry.async_remove(data[ATTR_ENTITY_ID])
        await self.store.async_save(self._entities)
