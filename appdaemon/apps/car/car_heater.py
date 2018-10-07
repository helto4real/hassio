from base import Base
from globals import GlobalEvents, presence_state
from typing import Tuple, Union
from datetime import time, datetime, timedelta


class CarHeaterManager(Base):
    """
    CarHeaterManager provides functionality of the following use-cases.

    - Turns on the heater at a given depature time time before a specific 
      time that are dependent on temperature outside
    - Always turn off after 3 hours or both adults are away at least 15 km
    - Press a button to heat car now and 3 hours
    - Press a (same) button to turn off heat
    - confirmation TTS at hallway if time is in between 07:00-22:00. 
    """


    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class

        self._heater_switch = self.args.get('heater_switch', str)
        self._sensor_time_for_departure = self.args.get('sensor_time_for_departure', str)
        self._sensor_temperature = self.args.get('sensor_temperature', str)
        self._input_schedule_on_weekends = self.args.get('input_schedule_on_weekends', str)
        self._tts_device = self.args.get('tts_device', str)
        self._max_time = int(self.args.get('max_time', 180)) #Minutes

        self._timer_stop_handle = None
        self._scheduled_heating_stop_time_handle = None
        self._scheduled_heating_start_time_handle = None
        self._time_to_depart = None

        self.listen_state(
            self.__on_heater_on, new='on', old='off', entity=self._heater_switch)
        self.listen_state(
            self.__on_new_time_for_departure, entity=self._sensor_time_for_departure
        )
        self.listen_state(
            self.__on_schedule_on_weekends_changed, entity=self._input_schedule_on_weekends
        )

        # Get the configured depature time
        departure_time = self.parse_time(
            self.get_state(self._sensor_time_for_departure) + ':00')
        # Get the schedule on weekdays state
        self._schedule_weekends = self.get_state(self._input_schedule_on_weekends)
        # Make initial schedule
        self.__schedule_start_stop_heater(departure_time)


    def __on_heater_on(
        self, entity: Union[str, dict], attribute: str, old: dict,
        new: dict, kwargs: dict) -> None:
        """Call when heater switch is turned on."""
        if self._timer_stop_handle is not None:
            self.cancel_timer(self._timer_stop_handle)
            self._timer_stop_handle = None
        
        self.run_in(self.__on_turn_off_heater, self._max_time*60)
    

    def __on_schedule_on_weekends_changed(
        self, entity: Union[str, dict], attribute: str, old: str,
        new: str, kwargs: dict) -> None:
        """Set if schedule should run on weekends"""
        self._schedule_weekends = new
        departure_time = self.parse_time(
            self.get_state(self._sensor_time_for_departure) + ':00')

        self.__schedule_start_stop_heater(departure_time)


    def __on_new_time_for_departure(
        self, entity: Union[str, dict], attribute: str, old: str,
        new: str, kwargs: dict) -> None:
        """New time for departure is set in GUI."""
        time_str = new + ':00'
        new_time: datetime = self.parse_time(time_str)
        
        self.__schedule_start_stop_heater(new_time)
        
    
    def __schedule_start_stop_heater(self, start_time: time) -> None:
        """Schedule start heater time, default 3 hours before departure.
        
           The heater callback function will later chef if
           3 hours is too soon to start heating depending 
           on the temperature
        """
        self.__cancel_scheduled_timers()

        self._time_to_depart = self.datetime().replace(
            hour=start_time.hour,
            minute=start_time.minute,
            second=start_time.second)

        # Add a full day if time passed
        if self._time_to_depart < self.datetime():
            self._time_to_depart = self._time_to_depart + timedelta(days=1)

        if self._time_to_depart.weekday() >= 5 and \
           self._schedule_weekends == 'off':
           # Skip days to next weekday
           while self._time_to_depart.weekday() >=5:
               self._time_to_depart = self._time_to_depart + timedelta(days=1)

        # Create the stop time at departure time
        self._scheduled_heating_stop_time_handle = \
            self.run_at(self.__on_turn_off_heater, self._time_to_depart)

        diff = self._time_to_depart - self.datetime()
        if diff.days == 0 and \
            diff.seconds < 3600*3:
            # It is closer than 3 hours, start heater now!
            self.__start_heater({})
            return

        # Schedule heater to start 3 hours before departure time
        time_to_start_heater = self._time_to_depart - timedelta(hours=3)
        self._scheduled_heating_start_time_handle = \
            self.run_at(self.__start_heater, time_to_start_heater)
        

    def __start_heater(self, kwargs: dict) -> None:
        """Start heater depending on temperature outside.

        This function will always be called 3 hours before 
        departure time, temperature will decide the start
        time.
        """
        
        def schedule_start_time(seconds: int):
            """Schedule the calculated starttime"""
            self.run_in(self.__start_heater, seconds)
            self.log("Temperature ({}) scedule in {} minutes".format(temp, round(seconds/60)))

        temp = float(self.get_state(self._sensor_temperature))
        if temp > 5.0:
            # No heating above 5 degrees celcius
            return

        diff = self._time_to_depart - self.datetime()

        if 1.0 < temp <= 5.0:
            # We should use 30 minutes timer
            if diff.seconds > 30*60:
                schedule_start_time(diff.seconds-30*60)
                return
        elif -10.0 < temp < 1.0:
            # we use 60 minutes
            if diff.seconds > 60*60:
                schedule_start_time(diff.seconds-60*60)
                return
        elif -20.0 < temp < -10:
            # we use 120 minutes
            if diff.seconds > 120*60:
                schedule_start_time(diff.seconds-120*60)
                return
        elif temp <= -20.0:
            # we use 180 minutes
            pass

        self.__turn_on_heater()
    

    def __turn_on_heater(self):
        """Turn on heater switch."""
        self.turn_on(self._heater_switch)


    def __on_turn_off_heater(self, kwargs: dict) -> None:
        """Turn off heater switch."""
        self.turn_off(self._heater_switch)


    def __cancel_scheduled_timers(self):
        """Cancel the scheduled timer"""
        # Cancel all current schedules if exist
        if self._scheduled_heating_start_time_handle is not None:
            # Cancel start timer
            self.cancel_timer(self._scheduled_heating_start_time_handle)
        if self._scheduled_heating_stop_time_handle is not None:
            # Cancel stop timer
            self.cancel_timer(self._scheduled_heating_stop_time_handle)

        self._scheduled_heating_stop_time_handle = None
        self._scheduled_heating_start_time_handle = None