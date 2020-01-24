from area import Area
from globals import GlobalEvents, HouseModes
from typing import Tuple, Union
import datetime

'''
Cusomizations:
- Bedtime earlier

'''
class SallysRoom(Area):
    def initialize(self) -> None:
        super().initialize()

        # Set callback when it is nighttime on days when go to bed late
        self.run_daily(
            self.__on_time_for_sleep,
            datetime.time(22, 00, 0)
            )

    def __on_time_for_sleep(self, kwargs: dict) -> None:
        """Time to set the house mode to day."""
        self.turn_off_ambient()
            