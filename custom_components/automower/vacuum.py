"""
"Vacuum" for Husqvarna Automowers.

For more details about this platform, please refer to the documentation at
https://home-assistant.io/components/vacuum.automower/
"""

from custom_components.automower import DOMAIN as AUTOMOWER_DOMAIN

DEPENDENCIES = ['automower']

def setup_platform(hass, config, add_devices, discovery_info=None):
    """Set up the Husqvarna Automower sensor platform."""
    add_devices(hass.data[AUTOMOWER_DOMAIN]['devices'], True)
