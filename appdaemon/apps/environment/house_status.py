import datetime
from enum import Enum
from typing import Tuple, Union

from base import App
from globals import GlobalEvents, HouseModes

"""
    Handles the status of the house, alot of the automations are depending on the
    status. More statuses to follow. 
        - Morning  (Sunrise plus offset)
        - Day      (Specific time)
        - Evening  (Sunset plus offset)
        - Night    (Specific time, different on weekdays and weekends)
        - Guest    (to be implemented, guest mode)
        - All off  (to be implemented, no automation)
"""
class HouseStatusManager(App):
    
    HOUSE_MODE_SELECT = 'input_select.house_mode_select'

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()
   
        self._current_state = HouseModes(self.get_state(self.HOUSE_MODE_SELECT))
        self._offset_sunrise = int(self.properties.get('sunrise_offset', 0))*60
        self._offset_sunset = int(self.properties.get('sunset_offset', 0))*60
   
        self._early_night_time = self.parse_time(self.properties.get('early_night_time', datetime.time(hour=23)))
        self._late_night_time = self.parse_time(self.properties.get('late_night_time', datetime.time(minute=15)))
        self. _day_time = self.parse_time(self.properties.get('day_time', datetime.time(hour=10)))

        self._early_nights = self.args.get('early_nights', {})
        self._late_nights = self.args.get('late_nights', {})

        self.listen_state(
            self.__house_mode_change,
            self.HOUSE_MODE_SELECT,
            attribute='all',
            duration=10
        )

        # Set sunrise/sunset events
        self.run_at_sunrise(self.__on_sunrise, offset=self._offset_sunrise)
        self.run_at_sunset(self.__on_sunset, offset=self._offset_sunset )

        # Set callback when it is nighttime on days when go to bed early
        self.run_on_days(
            self,
            self.__on_night_time, self._early_nights,
            self._early_night_time
            )

        # Set callback when it is nighttime on days when go to bed late
        self.run_on_days(
            self,
            self.__on_night_time, self._late_nights,
            self._late_night_time
            )

        # Set callback when it is nighttime on days when go to bed late
        self.run_daily(
            self.__on_day_time,
            self._day_time
            )

        self.log("Setting early night-mode on {} at {}".format(self._early_nights, self._early_night_time))
        self.log("Setting late night-mode on {} at {}".format(self._late_nights, self._late_night_time))
        self.log("Setting day time at {}".format(self._day_time))
        self.log("Next sunset is: {}".format(self.sunset()))
        self.log("Next sunrise is: {}".format(self.sunrise()))

    def is_night(self)->bool:
        """returns True if night else False"""
        if self._current_state == HouseModes.night:
            return True
        else:
            return False
    
    @property
    def current_state(self)->HouseModes:
        return self._current_state

    def __on_day_time(self, kwargs: dict) -> None:
        """Time to set the house mode to day."""
        
        self.log("DAYTIME EVENT")
        self.set_state(self.HOUSE_MODE_SELECT, state=HouseModes.day.value)

    def __on_night_time(self, kwargs: dict) -> None:
        """Time to set the house mode to night."""
        
        self.log("NIGHTTIME EVENT")
        self.set_state(self.HOUSE_MODE_SELECT, state=HouseModes.night.value)

    
    def __house_mode_change(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        """called when house mode changes"""

        new_mode = HouseModes(new['state']).value
        old_mode = HouseModes(old['state']).value
        self._current_state = HouseModes(new_mode)

        self.fire_event(
            GlobalEvents.EV_HOUSE_MODE_CHANGED.value, 
            old=old_mode, 
            new=new_mode)
        self.log_to_logbook('House', "Ny state  {}".format(new_mode))
    
    def __on_sunrise(self, kwargs: dict)->None:
        """called when sunrise plus offset"""
        self.log("SUNRISE EVENT")
        self.set_state(self.HOUSE_MODE_SELECT, state=HouseModes.morning.value)

    def __on_sunset(self, kwargs: dict)->None:
        """called when sunset plus offset"""
        self.log("SUNSET EVENT")
        if float(self.get_state('sensor.yr_cloudiness')) > 90.0:
            # It is cloudy set evening status now
            self.log("CLOUDY! SETTING EVENING NOW")
            self.set_state(self.HOUSE_MODE_SELECT, state=HouseModes.evening.value)
        else:
            # Set lights in one hour from now
            self.log("NOT CLOUDY WAITING 45 MINUTES")
            self.run_in(
                self.__on_timer,
                45*60)

    def __on_timer(self, kwargs: dict) -> None:
        """Not cloudy, set evening now instead"""
        self.log("NOT CLOUDY SETTING EVENING")
        self.set_state(self.HOUSE_MODE_SELECT, state=HouseModes.evening.value)
