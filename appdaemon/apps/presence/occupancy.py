from base import Base
from globals import GlobalEvents, presence_state
from typing import Tuple, Union
from operator import itemgetter
import datetime, time

"""
Class OccupancyManager the occupancy stuff in the solition

- creates and maintains a sensor if the house is occupied or not

"""
class OccupancyManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class

        self._motion_detectors = self.args.get('motion_detectors', {})
        self._presence_sensors = self.args.get('presence_sensors', {})
        self._min_time_passed_for_motion = self.properties.get('min_time_passed_for_motion', 60)

        self.__check_house_occupancy()
    
        self.run_minutely(self.__on_every_minute, datetime.time(0, 0, 0))

    def __on_every_minute(self, kwargs: dict)->None:
        self.__check_house_occupancy()

    def __check_house_occupancy(self) -> None:
        # first check the time of last changed for the motion detectors. 
        # We will use last_updated attribute cause we dont need to know if  
        # it is currently detecting motion, we will manage that listen to state changes

        attributes = {}
        state = 'not_home'
        
        # first get state for all the motion sensors
        states = [self.get_state(md, attribute='all') for md in self._motion_detectors]
            
            
        # sort result by last updated
        sorted_md_list = sorted(states, key=lambda k : self.__parse_date_time_string(k['last_updated']), reverse=True)

        attributes['last_seen'] = "{} {} minutes ago".format(sorted_md_list[0]['attributes']['friendly_name'], self.__passed_time_in_minutes(sorted_md_list[0]['last_updated']))
        attributes['time_last_seen'] = local_time_str(self.__parse_date_time_string(sorted_md_list[0]['last_updated']))
        for md in sorted_md_list:
            passed_time = self.__passed_time_in_minutes(md['last_updated']) 
            if passed_time <= self._min_time_passed_for_motion:
                self.set_state("sensor.occupancy", state='home', attributes=attributes)
                return
        
        
        for presence in self._presence_sensors:
            state = self.get_state(presence)
            if state == presence_state['home'] or state == presence_state['just_arrived']:
                self.set_state("sensor.occupancy", state='home', attributes=attributes)
                return

        self.set_state("sensor.occupancy", state='not_home', attributes=attributes)

    def __passed_time_in_minutes(self, last_updated:str) -> bool:
        dt_last_updated = self.__parse_date_time_string(last_updated)
        diff = datetime.datetime.now(datetime.timezone.utc) - dt_last_updated
        return int(round(diff.total_seconds()/60, 0))


    # Assumes format dateTtime.microsecods+00:00 , feels like ugly code but what the hell
    def __parse_date_time_string(self, datetimestring:str) -> datetime.datetime:
        lenToUTC = len(datetimestring)-6
        strToParse = datetimestring[:lenToUTC]+datetimestring[lenToUTC:lenToUTC+3]+datetimestring[lenToUTC+4:]
        return datetime.datetime.strptime(strToParse, '%Y-%m-%dT%H:%M:%S.%f%z')

####
# Common functions

# converts to local time for printing
def local_time_str(utc_datetime:datetime.datetime) -> str:
    now_timestamp = time.time()
    offset = datetime.datetime.fromtimestamp(now_timestamp) - datetime.datetime.utcfromtimestamp(now_timestamp)
    local_datetime = utc_datetime + offset
    return local_datetime.strftime("%Y-%m-%d %H:%M")
