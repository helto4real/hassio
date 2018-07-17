from homeassistant.components.switch import SwitchDevice, PLATFORM_SCHEMA
import logging
from urllib.request import urlopen
import uuid
import struct, socket
import voluptuous as vol

_LOGGER = logging.getLogger(__name__)

# PLATFORM_SCHEMA = PLATFORM_SCHEMA.extend({
#     vol.Optional('entities', default={}): {
#         cv.string: vol.Schema({
#             vol.Required(CONF_NAME): cv.string,
#             vol.Optional(CONF_FIRE_EVENT, default=False): cv.boolean,
#         })
#     },
#     vol.Optional(CONF_AUTOMATIC_ADD, default=False):  cv.boolean,
#     vol.Optional(CONF_SIGNAL_REPETITIONS, default=DEFAULT_SIGNAL_REPETITIONS):
#         vol.Coerce(int),
# })


def setup_platform(hass, config, add_devices, discovery_info=None):
    """Set up the ZigBee switch platform."""
    _LOGGER.info("TEST MESSAGE")
    _LOGGER.info(config)
    entities = config.get('entities', {})
    _LOGGER.info("Ent: {}".format(entities))
    devices = []

    for entity in entities:
        _LOGGER.info("Adding device : {} ({},{})".format(entity, entities[entity]['ip'], entities[entity]['mac']))
        devices.append(ComputerSwitch(hass, entity, entities[entity]['ip'], entities[entity]['mac']))

    add_devices(devices)

class ComputerSwitch(SwitchDevice):
    """Representation of a ZigBee Digital Out device."""
    def __init__(self, hass, name:str, ip:str, mac:str):
        """Initialize the AdsSwitch entity."""

        self._name = "switch.{}".format(name)
        self._ip = ip
        self._mac = mac
        _LOGGER.info("INIT DEVICE {}".format(self._name))

        if self.__computer_is_awake():
            _LOGGER.info("STATE ON FOR DEVICE {}".format(self._name))
            self._state = 'on'
            self._target_state = True
        else:
            _LOGGER.info("STATE OFF FOR DEVICE {}".format(self._name))
            self._state = 'off'
            self._target_state = False
        
    @property
    def should_poll(self):
        """Return the polling state."""
        return True

    @property
    def unique_id(self):
        """Return the unique ID of the device."""
        return "{}-cp".format(self.mac)

    @property
    def name(self):
        """Return the name of the entity."""
        return self._name
    
    @property
    def is_on(self):
        """Return true if the device is on."""
        return self.__computer_is_awake()

    @property
    def state(self):
        """Return the state of the switch."""
        return self._state

    def update(self):
        """Update setting state."""
        _LOGGER.debug("GETING STATE FOR {}".format(self._name))

        if self.__computer_is_awake():
            self._state = 'on'
        else:
            self._state = 'off'


    def turn_on(self, **kwargs):
        """Turn the switch on."""
        _LOGGER.info("TURN ON THE {}".format(self._name))
        self._target_state = True

        # todo fix the code here later to call wake on lan

    def turn_off(self, **kwargs):
        """Turn the switch off."""
        _LOGGER.info("TURN OFF THE {}".format(self._name))
        self._target_state = False

        # todo fix the code here later to call the webservice to hibernate computer

    def __computer_is_awake(self)->bool:
        try:
            _LOGGER.info("CHECK AWAKE")
            response = urlopen("http://{}:8009".format(self._ip), timeout=1)
            return True
        except:
          #  _LOGGER.warn("Error reading:" + sys.exc_info()[0])
            return False