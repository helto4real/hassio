import voluptuous as vol
import logging

from collections import OrderedDict
from datetime import datetime, date

from homeassistant import config_entries
from homeassistant.const import CONF_USERNAME, CONF_PASSWORD, CONF_NAME

import homeassistant.helpers.config_validation as cv

from homeassistant.core import HomeAssistant, callback
from homeassistant.helpers import aiohttp_client
from homeassistant.util import slugify

from .const import DOMAIN

_LOGGER = logging.getLogger(__name__)


@config_entries.HANDLERS.register(DOMAIN)
class RecyclingFlowHandler(config_entries.ConfigFlow):
    """Config flow for myfitnespal component."""

    VERSION = 1
    CONNECTION_CLASS = config_entries.CONN_CLASS_CLOUD_POLL

    def __init__(self) -> None:
        """Initialize myfitnesspal configuration flow."""
        self._errors = {}

    async def async_step_user(self, user_input=None):
        """Handle a flow initialized by the user."""
        self._errors = {}

        if user_input is not None:
            is_ok = await self._check_user(
                user_input[CONF_USERNAME], user_input[CONF_PASSWORD]
            )
            if is_ok:
                return self.async_create_entry(
                    title=user_input[CONF_NAME], data=user_input
                )
            else:
                self._errors["base"] = "wrong_credentials"

            return await self._show_config_form(
                user_input[CONF_NAME],
                user_input[CONF_USERNAME],
                user_input[CONF_PASSWORD],
            )

        return await self._show_config_form()

    async def _show_config_form(
        self, name: str = None, user_name: str = None, password: str = None
    ):
        """Show the configuration form to edit location data."""
        data_schema = OrderedDict()
        data_schema[vol.Required(CONF_NAME, default=name)] = str
        data_schema[vol.Required(CONF_USERNAME, default=user_name)] = str
        data_schema[vol.Required(CONF_PASSWORD, default=password)] = str

        return self.async_show_form(
            step_id="user", data_schema=vol.Schema(data_schema), errors=self._errors
        )

    async def _check_user(self, user_name: str, password: str) -> bool:
        """Return true if location is ok."""

        self._flow_user_name = user_name
        self._flow_password = password

        # Sadly a sync lib
        return await self.hass.async_add_executor_job(self._sync_make_api_call)

    def _sync_make_api_call(self) -> bool:
        """syncronous call to the api"""
        import myfitnesspal as ext_myfitnesspal

        try:
            today = date.today()
            client = ext_myfitnesspal.Client(self._flow_user_name, self._flow_password)
            info = client.get_date(today.year, today.month, today.day)

            if info is not None:
                return True
        except:
            # The API will throw an exception if faulty location
            pass

        return False
