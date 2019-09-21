import voluptuous as vol
import logging

from collections import OrderedDict
from datetime import datetime

from homeassistant import config_entries
from homeassistant.const import CONF_LATITUDE, CONF_LONGITUDE, CONF_NAME

import homeassistant.helpers.config_validation as cv

from homeassistant.core import HomeAssistant, callback
from homeassistant.helpers import aiohttp_client
from homeassistant.util import slugify

from .api import get_data_from_api
from .const import DOMAIN, CONF_STATION_ID, CONF_USE_AS_STATE, CONF_NAME

_LOGGER = logging.getLogger(__name__)


@config_entries.HANDLERS.register(DOMAIN)
class RecyclingFlowHandler(config_entries.ConfigFlow):
    """Config flow for SMHI component."""

    VERSION = 1
    CONNECTION_CLASS = config_entries.CONN_CLASS_CLOUD_POLL

    def __init__(self) -> None:
        """Initialize SMHI forecast configuration flow."""
        self._errors = {}

    async def async_step_user(self, user_input=None):
        """Handle a flow initialized by the user."""
        self._errors = {}

        if user_input is not None:
            is_ok = await self._check_station_id(
                user_input[CONF_STATION_ID], user_input[CONF_USE_AS_STATE]
            )
            if is_ok:
                return self.async_create_entry(
                    title=user_input[CONF_NAME], data=user_input
                )
            else:
                self._errors["base"] = "wrong_station_id_or_use_as_state"

            return await self._show_config_form(
                user_input[CONF_STATION_ID],
                user_input[CONF_NAME],
                user_input[CONF_USE_AS_STATE],
            )

        return await self._show_config_form()

    async def _show_config_form(
        self, station_id: int = 0, name: str = None, use_as_state: str = None
    ):
        """Show the configuration form to edit location data."""
        data_schema = OrderedDict()
        data_schema[vol.Required(CONF_NAME, default=name)] = str
        data_schema[vol.Required(CONF_STATION_ID, default=station_id)] = int
        data_schema[vol.Required(CONF_USE_AS_STATE, default=use_as_state)] = vol.In(
            [
                "NextCleaning",
                "NextColoredGlass",
                "NextGlass",
                "NextCarton",
                "NextMetal",
                "NextPlastic",
                "NextPapers",
            ]
        )
        return self.async_show_form(
            step_id="user", data_schema=vol.Schema(data_schema), errors=self._errors
        )

    async def _check_station_id(self, station_id: int, use_as_state: str) -> bool:
        """Return true if location is ok."""

        try:
            session = aiohttp_client.async_get_clientsession(self.hass)
            data = await get_data_from_api(session, station_id)
            use_as_state_data = data.get(use_as_state)
            if use_as_state_data is not None and type(use_as_state_data) is datetime:
                return True
        except:
            # The API will throw an exception if faulty location
            pass

        return False
