"""Constants for NetDaemon."""
import logging

LOGGER: logging.Logger = logging.getLogger(__package__)

INTEGRATION_VERSION = "21.50.0"
DOMAIN = "netdaemon"
NAME = "NetDaemon"
MINIMUM_HA_VERSION = "2020.12.0"
STORAGE_VERSION = "1"

ND_ID = "86ec6a70-b2b8-427d-8fcf-3f14331dddd7"

ATTR_CLASS = "class"
ATTR_CLIENT = "client"
ATTR_SERVICE = "service"
ATTR_COORDINATOR = "coordinator"
ATTR_METHOD = "method"
ATTR_ENTITY_ID = "entity_id"
ATTR_STATE = "state"
ATTR_HVAC_MODE = "hvac_mode"
ATTR_ICON = "icon"
ATTR_UNIT = "unit"
ATTR_ATTRIBUTES = "attributes"
ATTR_VERSION = "version"
ATTR_TARGET_TEMPERATURE = "target_temperature"
ATTR_TARGET_HUMIDITY = "target_humidity"
ATTR_TEMPERATURE_UNIT = "temperature_unit"
TEMP_CELSIUS = "°C"

REASON_MIN_HA_VERSION = "min_ha_version"
REASON_SINGLE = "single_instance_allowed"

ACKNOWLEDGE_ISSUES = "acc_issues"
ACKNOWLEDGE_NETDAEMON = "acc_netdaemon"
ACKNOWLEDGE_DISABLE = "acc_disable"

ERROR_BASE = "base"
ERROR_ACC = "acc"

DEFAULT_CLASS = "no class provided"
DEFAULT_METHOD = "no method provided"

API_PATH_VERSION = "version"
API_PATH_INFO = "info"
API_PATH_PING = "ping"
API_PATH_PONG = "pong"

API_RESPONSE_PING = "ping"
API_RESPONSE_PONG = "pong"

SERVICE_REGISTER_SERVICE = "register_service"
SERVICE_RELOAD_APPS = "reload_apps"
SERVICE_ENTITY_CREATE = "entity_create"
SERVICE_ENTITY_UPDATE = "entity_update"
SERVICE_ENTITY_REMOVE = "entity_remove"

PLATFORM_BINARY_SENSOR = "binary_sensor"
PLATFORM_SENSOR = "sensor"
PLATFORM_SWITCH = "switch"
PLATFORM_CLIMATE = "climate"

PLATFORMS = [
    PLATFORM_BINARY_SENSOR,
    PLATFORM_SENSOR,
    PLATFORM_SWITCH,
    PLATFORM_CLIMATE,
]

STATE_ON_VALUES = set(["true", "on", "1"])

STARTUP = f"""
-------------------------------------------------------------------
NetDaemon
Version: {INTEGRATION_VERSION}
This is a custom integration
If you have any issues with this you need to open an issue here:
https://github.com/net-daemon/integration/issues
-------------------------------------------------------------------
"""
