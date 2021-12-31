"""Climate platform for NetDaemon."""
from typing import TYPE_CHECKING

from homeassistant.components.climate import (
    ClimateEntity,
    ATTR_HVAC_MODE,
    ATTR_HVAC_MODES,
    ATTR_FAN_MODE,
    ATTR_FAN_MODES,
    ATTR_CURRENT_TEMPERATURE,
    ATTR_TEMPERATURE,
)
from homeassistant.components.climate.const import ATTR_HUMIDITY
from homeassistant.const import ATTR_SUPPORTED_FEATURES

from .const import (
    ATTR_ATTRIBUTES,
    ATTR_CLIENT,
    ATTR_COORDINATOR,
    ATTR_ENTITY_ID,
    ATTR_STATE,
    DOMAIN,
    TEMP_CELSIUS,
    LOGGER,
    PLATFORM_CLIMATE,
    ATTR_TEMPERATURE_UNIT,
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

    climate_entities = []
    for entity in client.entities:
        if entity.split(".")[0] == PLATFORM_CLIMATE:
            LOGGER.debug("Adding %s", entity)
            climate_entities.append(
                NetDaemonClimateEntity(coordinator, entity.split(".")[1])
            )

    if climate_entities:
        async_add_devices(climate_entities)


class NetDaemonClimateEntity(NetDaemonEntity, ClimateEntity):
    """NetDaemon ClimateEntity class."""

    @property
    def supported_features(self) -> int:
        """Return the list of supported features."""
        if not self.entity_id:
            return 0
        return (
            self._coordinator.data[self.entity_id]
            .get(ATTR_ATTRIBUTES, {})
            .get(ATTR_SUPPORTED_FEATURES, 0)
        )

    @property
    def temperature_unit(self) -> str:
        """Return the unit of measurement used by the platform."""
        if not self.entity_id:
            return TEMP_CELSIUS
        return (
            self._coordinator.data[self.entity_id]
            .get(ATTR_ATTRIBUTES, {})
            .get(ATTR_TEMPERATURE_UNIT, TEMP_CELSIUS)
        )

    @property
    def hvac_mode(self) -> str:
        """Return hvac operation ie. heat, cool mode.

        Need to be one of HVAC_MODE_*.
        """
        if not self.entity_id:
            return "off"
        return self._coordinator.data[self.entity_id].get(ATTR_STATE, "off")

    @property
    def current_temperature(self) -> float:
        """Return the current temperature."""
        if not self.entity_id:
            return 0.0
        return (
            self._coordinator.data[self.entity_id]
            .get(ATTR_ATTRIBUTES, {})
            .get(ATTR_CURRENT_TEMPERATURE, 0.0)
        )

    @property
    def target_temperature(self) -> float:
        """Return the temperature we try to reach."""
        if not self.entity_id:
            return 0.0
        return (
            self._coordinator.data[self.entity_id]
            .get(ATTR_ATTRIBUTES, {})
            .get(ATTR_TEMPERATURE, 0.0)
        )

    @property
    def target_humidity(self) -> int:
        """Return the humidity we try to reach."""
        if not self.entity_id:
            return 0
        return (
            self._coordinator.data[self.entity_id]
            .get(ATTR_ATTRIBUTES, {})
            .get(ATTR_HUMIDITY, 0)
        )

    @property
    def hvac_modes(self) -> list[str]:
        """Return the list of available hvac operation modes.

        Need to be a subset of HVAC_MODES.
        """
        if not self.entity_id:
            return ["off"]

        return (
            self._coordinator.data[self.entity_id]
            .get(ATTR_ATTRIBUTES, {})
            .get(ATTR_HVAC_MODES, ["off"])
        )

    @property
    def fan_modes(self) -> list[str]:
        """Return the list of available fan modes.

        Requires SUPPORT_FAN_MODE.
        """
        if not self.entity_id:
            return ["off"]

        return (
            self._coordinator.data[self.entity_id]
            .get(ATTR_ATTRIBUTES, {})
            .get(ATTR_FAN_MODES, ["off"])
        )

    async def async_set_temperature(self, **kwargs) -> None:
        """Set new target temperature."""
        if not self.entity_id:
            LOGGER.error("Setting target temperature on non existing climate entity")
            return
        temperature = kwargs.get(ATTR_TEMPERATURE)
        attributes = self._coordinator.data[self.entity_id][ATTR_ATTRIBUTES]
        attributes[ATTR_TEMPERATURE] = temperature
        await self.hass.data[DOMAIN][ATTR_CLIENT].entity_update(
            {
                ATTR_ENTITY_ID: self.entity_id,
                ATTR_ATTRIBUTES: attributes,
            }
        )
        self.async_write_ha_state()

    async def async_set_humidity(self, humidity: int) -> None:
        """Set new target humidity."""
        if not self.entity_id:
            LOGGER.error("Setting target humidity on non existing climate entity")
            return
        attributes = self._coordinator.data[self.entity_id][ATTR_ATTRIBUTES]
        attributes[ATTR_HUMIDITY] = humidity
        await self.hass.data[DOMAIN][ATTR_CLIENT].entity_update(
            {
                ATTR_ENTITY_ID: self.entity_id,
                ATTR_ATTRIBUTES: attributes,
            }
        )
        self.async_write_ha_state()

    async def async_set_fan_mode(self, fan_mode: str) -> None:
        """Set new target fan mode."""
        if not self.entity_id:
            LOGGER.error("Setting target humidity on non existing climate entity")
            return
        attributes = self._coordinator.data[self.entity_id][ATTR_ATTRIBUTES]
        attributes[ATTR_FAN_MODE] = fan_mode
        await self.hass.data[DOMAIN][ATTR_CLIENT].entity_update(
            {
                ATTR_ENTITY_ID: self.entity_id,
                ATTR_ATTRIBUTES: attributes,
            }
        )
        self.async_write_ha_state()

    async def async_set_hvac_mode(self, hvac_mode: str) -> None:
        """Set new target hvac mode."""
        if not self.entity_id:
            LOGGER.error("Setting hvac mode on non existing climate entity")
            return

        attributes = self._coordinator.data[self.entity_id][ATTR_ATTRIBUTES]
        attributes[ATTR_HVAC_MODE] = hvac_mode
        LOGGER.debug("Set hwac_mode %s %s", self.entity_id, hvac_mode)
        await self.hass.data[DOMAIN][ATTR_CLIENT].entity_update(
            {
                ATTR_ENTITY_ID: self.entity_id,
                ATTR_STATE: hvac_mode,
                ATTR_ATTRIBUTES: attributes,
            }
        )
        self.async_write_ha_state()
