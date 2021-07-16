"""
Platform for Husqvarna Automowers.

For more details about this component, please refer to the documentation
https://home-assistant.io/components/automower/
"""

import copy
import logging
import voluptuous as vol

from datetime import datetime
from homeassistant.const import CONF_ICON, CONF_PASSWORD, CONF_SCAN_INTERVAL, CONF_USERNAME
try:
    from homeassistant.components.vacuum import (
    SUPPORT_BATTERY, SUPPORT_PAUSE, SUPPORT_RETURN_HOME,
    SUPPORT_STATUS, SUPPORT_STOP, SUPPORT_TURN_OFF,
    SUPPORT_TURN_ON, VacuumEntity)
except ImportError:
    from homeassistant.components.vacuum import (
    SUPPORT_BATTERY, SUPPORT_PAUSE, SUPPORT_RETURN_HOME,
    SUPPORT_STATUS, SUPPORT_STOP, SUPPORT_TURN_OFF,
    SUPPORT_TURN_ON, VacuumDevice as VacuumEntity)

from homeassistant.helpers import config_validation as cv
from homeassistant.helpers import discovery
from homeassistant.util import slugify

_LOGGER = logging.getLogger(__name__)

DEFAULT_ICON = 'mdi:robot-mower'
DOMAIN = 'automower'
REQUIREMENTS = ['pyhusmow==0.1.1']
VENDOR = 'Husqvarna'

# TODO: Add more statuses as we observe them
STATUS_ERROR =                  'ERROR'
STATUS_OK_CHARGING =            'OK_CHARGING'
STATUS_OK_CUTTING =             'OK_CUTTING'
STATUS_OK_CUTTING_MANUAL =      'OK_CUTTING_NOT_AUTO'
STATUS_OK_LEAVING =             'OK_LEAVING'
STATUS_OK_SEARCHING =           'OK_SEARCHING'
STATUS_PARKED_TIMER =           'PARKED_TIMER'
STATUS_PARKED_AUTOTIMER =       'PARKED_AUTOTIMER'
STATUS_PARKED_PARKED_SELECTED = 'PARKED_PARKED_SELECTED'
STATUS_PAUSED =                 'PAUSED'
STATUS_EXECUTING_PARK =         'EXECUTING_PARK'
STATUS_EXECUTING_START =        'EXECUTING_START'
STATUS_EXECUTING_STOP =         'EXECUTING_STOP'
STATUS_WAIT_POWER_UP =          'WAIT_POWER_UP'
STATUS_OFF_HATCH_OPEN =         'OFF_HATCH_OPEN'
STATUS_OFF_HATCH_CLOSED =       'OFF_HATCH_CLOSED_DISABLED'
STATUS_OFF_DISABLED =           'OFF_DISABLED'

STATUSES = {
    STATUS_ERROR:                   { 'icon': 'mdi:alert',          'message': 'Error' },
    STATUS_OK_CHARGING:             { 'icon': 'mdi:power-plug',     'message': 'Charging' },
    STATUS_OK_CUTTING:              { 'icon': DEFAULT_ICON,         'message': 'Cutting' },
    STATUS_OK_CUTTING_MANUAL:       { 'icon': DEFAULT_ICON,         'message': 'Cutting (manual timer override)' },
    STATUS_OK_LEAVING:              { 'icon': DEFAULT_ICON,         'message': 'Leaving charging station' },
    STATUS_PAUSED:                  { 'icon': 'mdi:pause',          'message': 'Paused' },
    STATUS_PARKED_TIMER:            { 'icon': 'mdi:timetable',      'message': 'Parked due to timer' },
    STATUS_PARKED_AUTOTIMER:        { 'icon': 'mdi:timetable',      'message': 'Parked due to weather timer' },
    STATUS_PARKED_PARKED_SELECTED:  { 'icon': 'mdi:sleep',          'message': 'Parked manually' },
    STATUS_OK_SEARCHING:            { 'icon': 'mdi:magnify',        'message': 'Going to charging station' },
    STATUS_EXECUTING_START:         { 'icon': 'mdi:dots-horizontal','message': 'Starting...' },
    STATUS_EXECUTING_STOP:          { 'icon': 'mdi:dots-horizontal','message': 'Stopping...' },
    STATUS_EXECUTING_PARK:          { 'icon': 'mdi:dots-horizontal','message': 'Preparing to park...' },
    STATUS_WAIT_POWER_UP:           { 'icon': 'mdi:dots-horizontal','message': 'Powering up...' },
    STATUS_OFF_HATCH_OPEN:          { 'icon': 'mdi:alert',          'message': 'Hatch opened' },
    STATUS_OFF_HATCH_CLOSED:        { 'icon': 'mdi:pause',          'message': 'Stopped but not on base' },
    STATUS_OFF_DISABLED:            { 'icon': 'mdi:close-circle-outline', 'message': 'Off'}
}

# TODO: Add more error messages as we observe them
# https://developer.husqvarnagroup.cloud/apis/Automower+Connect+API#/status%20description%20and%20error%20codes
ERROR_MESSAGES = {
    0:  'Unexpected error',
    1:  'Outside working area',
    2:  'No loop signal',
    3:  'Wrong loop signal',
    4:  'Loop sensor problem, front',
    5:  'Loop sensor problem, rear',
    6:  'Loop sensor problem, left',
    7:  'Loop sensor problem, right',
    8:  'Wrong PIN code',
    9:  'Trapped',
    10: 'Upside down',
    11: 'Low battery',
    12: 'Empty battery',
    13: 'No drive',
    14: 'Mower lifted',
    15: 'Lifted',
    16: 'Stuck in charging station',
    17: 'Charging station blocked',
    18: 'Collision sensor problem, rear',
    19: 'Collision sensor problem, front',
    20: 'Wheel motor blocked, right',
    21: 'Wheel motor blocked, left',
    22: 'Wheel drive problem, right',
    23: 'Wheel drive problem, left',
    24: 'Cutting system blocked',
    25: 'Cutting system blocked',
    26: 'Invalid sub-device combination',
    27: 'Settings restored',
    28: 'Memory circuit problem',
    29: 'Slope too steep',
    30: 'Charging system problem',
    31: 'STOP button problem',
    32: 'Tilt sensor problem',
    33: 'Mower tilted',
    34: 'Cutting stopped - slope too steep',
    35: 'Wheel motor overloaded, right',
    36: 'Wheel motor overloaded, left',
    37: 'Charging current too high',
    38: 'Electronic problem',
    39: 'Cutting motor problem',
    40: 'Limited cutting height range',
    41: 'Unexpected cutting height adj',
    42: 'Limited cutting height range',
    43: 'Cutting height problem, drive',
    44: 'Cutting height problem, curr',
    45: 'Cutting height problem, dir',
    46: 'Cutting height blocked',
    47: 'Cutting height problem',
    48: 'No response from charger',
    49: 'Ultrasonic problem',
    50: 'Guide 1 not found',
    51: 'Guide 2 not found',
    52: 'Guide 3 not found',
    53: 'GPS navigation problem',
    54: 'Weak GPS signal',
    55: 'Difficult finding home',
    56: 'Guide calibration accomplished',
    57: 'Guide calibration failed',
    58: 'Temporary battery problem',
    59: 'Temporary battery problem',
    60: 'Temporary battery problem',
    61: 'Temporary battery problem',
    62: 'Temporary battery problem',
    63: 'Temporary battery problem',
    64: 'Temporary battery problem',
    65: 'Temporary battery problem',
    66: 'Battery problem',
    67: 'Battery problem',
    68: 'Temporary battery problem',
    69: 'Alarm! Mower switched off',
    70: 'Alarm! Mower stopped',
    71: 'Alarm! Mower lifted',
    72: 'Alarm! Mower tilted',
    73: 'Alarm! Mower in motion',
    74: 'Alarm! Outside geofence',
    75: 'Connection changed',
    76: 'Connection NOT changed',
    77: 'Com board not available',
    78: 'Slipped - Mower has Slipped.Situation not solved with moving pattern',
    79: 'Invalid battery combination - Invalid combination of different battery types.',
    80: 'Cutting system imbalance    Warning',
    81: 'Safety function faulty',
    82: 'Wheel motor blocked, rear right',
    83: 'Wheel motor blocked, rear left',
    84: 'Wheel drive problem, rear right',
    85: 'Wheel drive problem, rear left',
    86: 'Wheel motor overloaded, rear right',
    87: 'Wheel motor overloaded, rear left',
    88: 'Angular sensor problem',
    89: 'Invalid system configuration',
    90: 'No power in charging station',
}

# TODO: Add more models as we observe them
MODELS = {
    'E': 'Automower 420',
    'G': 'Automower 430X',
    'H': 'Automower 450X',
    'K': 'Automower 310',
    'L': 'Automower 315/X',
    'T': 'Automower 435X'
}

IGNORED_API_STATE_ATTRIBUTES = [
    'batteryPercent',
    'cachedSettingsUUID',
    'lastLocations',
    'mowerStatus',
    'valueFound'
]

AUTOMOWER_COMPONENTS = [
    'device_tracker', 'vacuum'
]

SUPPORTED_FEATURES = SUPPORT_TURN_ON | SUPPORT_TURN_OFF | SUPPORT_PAUSE | \
                     SUPPORT_STOP | SUPPORT_RETURN_HOME | \
                     SUPPORT_STATUS | SUPPORT_BATTERY


CONFIG_SCHEMA = vol.Schema({
    DOMAIN: vol.Schema({
        vol.Required(CONF_USERNAME): cv.string,
        vol.Required(CONF_PASSWORD): cv.string
    }),
}, extra=vol.ALLOW_EXTRA)

def setup(hass, base_config):
    """Establish connection to Husqvarna Automower API."""
    from pyhusmow import API as HUSMOW_API

    config = base_config.get(DOMAIN)

    if hass.data.get(DOMAIN) is None:
        hass.data[DOMAIN] = { 'devices': [] }

    api = HUSMOW_API()
    api.login(config.get(CONF_USERNAME), config.get(CONF_PASSWORD))

    robots = api.list_robots()

    if not robots:
        return False

    for robot in robots:
        hass.data[DOMAIN]['devices'].append(AutomowerDevice(robot, api))

    for component in AUTOMOWER_COMPONENTS:
        discovery.load_platform(hass, component, DOMAIN, {}, base_config)

    return True


class AutomowerDevice(VacuumEntity):
    """Representation of an Automower device."""

    def __init__(self, meta, api):
        """Initialisation of the Automower device."""
        _LOGGER.debug("Initializing device: %s", meta['name'])
        self._id = meta['id']
        self._name = meta['name']
        self._model = meta['model']
        self._state = None
        self._mower_status = None
        self._stored_timestamp = None
        self._see = None

        # clone already authenticated api client and
        # select automower for this instance
        self._api = copy.copy(api)
        self._api.select_robot(self._id)

    @property
    def id(self):
        """Return the id of the Automower."""
        return self._id

    @property
    def dev_id(self):
        """Return the device id of the Automower (for device tracker)."""
        return slugify("{0}_{1}_{2}".format(DOMAIN, self._model, self._id))

    @property
    def name(self):
        """Return the name of the Automower."""
        return self._name

    @property
    def model(self):
        """Return the model of the Automower."""
        return MODELS.get(self._model,self._model)

    @property
    def icon(self):
        """Return the icon for the frontend based on the status."""
        return STATUSES.get(self._mower_status, {}).get('icon', DEFAULT_ICON)

    @property
    def status(self):
        """Return the status of the automower as a nice formatted text (for vacuum platform)."""
        return STATUSES.get(self._mower_status, {}).get('message', self._mower_status)

    @property
    def state(self):
        """Return the state of the automower (same as status)."""
        return self.status

    @property
    def device_state_attributes(self):
        """Return the state attributes of the automower."""
        attributes = dict(self._state)

        # Parse timestamps
        for key in ['lastErrorCodeTimestamp', 'nextStartTimestamp', 'storedTimestamp']:
            if key in attributes:
                if isinstance(attributes[key], int):
                    # Sometimes(tm), Husqvarna will return a timestamp in millis :(
                    if attributes[key] > 999999999999:
                        attributes[key] /= 1000.0
                    attributes[key] = datetime.utcfromtimestamp(attributes[key])

        # Ignore some unneeded attributes & format error messages
        ignored_attributes = list(IGNORED_API_STATE_ATTRIBUTES)
        if attributes['lastErrorCode'] > 0:
            attributes['lastErrorMessage'] = ERROR_MESSAGES.get(attributes['lastErrorCode'])
        else:
            ignored_attributes.extend(['lastErrorCode', 'lastErrorCodeTimestamp', 'lastErrorMessage'])
        if attributes['nextStartSource'] == 'NO_SOURCE':
            ignored_attributes.append('nextStartTimestamp')

        return sorted({ k: v for k, v in attributes.items() if not k in ignored_attributes }.items())

    @property
    def battery(self):
        """Return the battery level of the automower (for device_tracker)."""
        return self._state['batteryPercent']

    @property
    def battery_level(self):
        """Return the battery level of the automower (for vacuum)."""
        return self.battery

    @property
    def supported_features(self):
        """Flag supported features."""
        return SUPPORTED_FEATURES

    @property
    def lat(self):
        """Return the current latitude of the automower."""
        return self._state['lastLocations'][0]['latitude']

    @property
    def lon(self):
        """Return the current longitude of the automower."""
        return self._state['lastLocations'][0]['longitude']

    @property
    def should_poll(self):
        """Automower devices need to be polled."""
        return True

    @property
    def is_on(self):
        """Return true if automower is starting, charging, cutting, or returning home."""
        return self._mower_status in [
            STATUS_EXECUTING_START, STATUS_OK_CHARGING,
            STATUS_OK_CUTTING, STATUS_OK_LEAVING, STATUS_OK_SEARCHING, STATUS_OK_CUTTING_MANUAL]

    def turn_on(self, **kwargs):
        """Start the automower unless on."""
        if not self.is_on:
            _LOGGER.debug("Sending START command to: %s", self._name)
            self._api.control('START')
            self._mower_status = STATUS_EXECUTING_START
            self.schedule_update_ha_state()

    def turn_off(self, **kwargs):
        """Stop the automower unless off."""
        if self.is_on:
            _LOGGER.debug("Sending STOP command to: %s", self._name)
            self._api.control('STOP')
            self._mower_status = STATUS_EXECUTING_STOP
            self.schedule_update_ha_state()

    def start_pause(self, **kwargs):
        """Toggle the automower start/stop state."""
        if self.is_on:
            self.turn_off()
        else:
            self.turn_on()

    def stop(self, **kwargs):
        """Stop the automower (alias for turn_off)."""
        self.turn_off()

    def return_to_base(self, **kwargs):
        """Park the automower."""
        _LOGGER.debug("Sending PARK command to: %s", self._name)
        self._api.control('PARK')
        self._mower_status = STATUS_EXECUTING_PARK
        self.schedule_update_ha_state()


    def set_see(self, see):
        self._see = see

    def update(self):
        """Update the automower state using the API."""
        _LOGGER.debug("Fetching state from API: %s", self._name)
        self._state = self._api.status()

        # Do not update internal mower status and timestamp if
        # stored timestamp equals the one we last saw.
        # This allows for our internal STATUS_EXECUTING_* to
        # remain active until there's an actual change from the
        # API.
        if self._stored_timestamp != self._state['storedTimestamp']:
            self._mower_status = self._state['mowerStatus']
            self._stored_timestamp = self._state['storedTimestamp']
        if self._see is not None:
            self.update_see()

    def update_see(self):
        """Update the device tracker."""
        _LOGGER.debug("Updating device tracker: %s", self._name)
        self._see(
            dev_id=self.dev_id,
            host_name=self.name,
            battery=self.battery,
            gps=(self.lat, self.lon),
            attributes={
                'status': self.status,
                'id': self.dev_id,
                'name': self.name,
                CONF_ICON: self.icon,
                'vendor': VENDOR,
                'model': self.model})
