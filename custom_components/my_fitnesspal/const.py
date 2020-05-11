"""Constants in myfitnesspal component."""

DOMAIN = "my_fitnesspal"


ATTRIBUTION = "Myfitnesspal.com"

NAME = "MyFitnessPal"
DEFAULT_NAME = "myfitnesspal"

ICON = "mdi:run-fast"

VERSION = "0.0.1"
ISSUE_URL = "https://github.com/helto4real/custom_component_myfitnesspal/issues"

SENSOR = "sensor"
PLATFORMS = [SENSOR]

STARTUP_MESSAGE = f"""
-------------------------------------------------------------------
{NAME}
Version: {VERSION}
This is a custom integration!
If you have any issues with this you need to open an issue here:
{ISSUE_URL}
-------------------------------------------------------------------
"""
