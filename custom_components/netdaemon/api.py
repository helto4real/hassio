"""NetDeamon API."""
from aiohttp import web
from homeassistant.components.http import HomeAssistantView

from .const import (
    API_PATH_INFO,
    API_PATH_PING,
    API_PATH_PONG,
    API_PATH_VERSION,
    API_RESPONSE_PING,
    API_RESPONSE_PONG,
    ATTR_VERSION,
    INTEGRATION_VERSION,
)


class NetDaemonApi(HomeAssistantView):
    """NetDaemon API Class."""

    requires_auth = False
    name = "api:netdaemon"
    url = r"/api/netdaemon/{requested_path:.+}"

    async def get(self, request, requested_path):  # pylint: disable=unused-argument
        """Handle API Web requests."""
        if requested_path == API_PATH_VERSION:
            return web.Response(text=INTEGRATION_VERSION, status=200)

        if requested_path == API_PATH_INFO:
            return web.json_response(
                data={ATTR_VERSION: INTEGRATION_VERSION}, status=200
            )

        if requested_path == API_PATH_PING:
            return web.Response(text=API_RESPONSE_PONG, status=200)

        if requested_path == API_PATH_PONG:
            return web.Response(text=API_RESPONSE_PING, status=200)

        return web.Response(status=404)
