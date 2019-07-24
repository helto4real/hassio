import aiohttp
import asyncio
import async_timeout
import json
import logging
import datetime
import re
from typing import Dict

from homeassistant.helpers import aiohttp_client

_LOGGER = logging.getLogger(__name__)

_MONTH = {
    "jan": 1,
    "feb": 2,
    "mar": 3,
    "apr": 4,
    "maj": 5,
    "jun": 6,
    "jul": 7,
    "aug": 8,
    "sep": 9,
    "okt": 10,
    "nov": 11,
    "dec": 12,
}


async def get_data_from_api(session, station_id: int) -> Dict[str, str]:
    """Get the actual data from the 'hidden' API"""

    api_url = (
        "https://webapp.ftiab.se/Code/Ajax/StationHandler.aspx/GetStationMaintenance"
    )
    payload = '{"stationId": "' + str(station_id) + '"}'
    headers = {"Content-Type": "application/json"}
    data_json = {}

    async with session.post(api_url, data=payload, headers=headers) as response:
        if response.status != 200:
            # Do some logging
            _LOGGER.warn(
                "Fail to get Swedish recycle information ID({})".format(station_id)
            )
            raise Exception()

        data = await response.text()
        response_json = json.loads(data)
        data_json = json.loads(response_json["d"])
        response_data = {}
        for attr, value in data_json.items():

            if "kl" in value:
                regular_expression = r"([0-9]+)\s([a-z]{3})\skl\s([0-9]+):([0-9]+)"
            else:
                regular_expression = r"([0-9]+)\s([a-z]{3})"
            date_split = re.split(regular_expression, value)
            if len(date_split) > 1:
                year = datetime.datetime.now().year
                month = _MONTH[date_split[2]]
                if month < datetime.datetime.now().month and attr.startswith("Next"):
                    year = year + 1

                if len(date_split) == 4:
                    response_data[attr] = datetime.datetime(
                        year, month, int(date_split[1])
                    )
                else:
                    response_data[attr] = datetime.datetime(
                        year,
                        month,
                        int(date_split[1]),
                        int(date_split[3]),
                        int(date_split[4]),
                    )
            else:
                response_data[attr] = value

        return response_data
