from base import Base
from typing import Tuple, Union
from globals import GlobalEvents, HouseModes

"""
    Creates a group with devices with battery below specified limit
"""
class BatteryManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

        self._low_battery_level:int = self.args.get('low_battery_level', 75)

        self.__get_devices_below_bat_level()

    def __get_devices_below_bat_level(self)->None:
        
        devices = []
        
        binary_sensors = {} 
        binary_sensors = self.get_state('binary_sensor')
        for binary_sensor in binary_sensors:
            temperature = binary_sensors[binary_sensor]['attributes'].get('battery_level', 101)
            if (temperature <= self._low_battery_level):
                devices.append(binary_sensor)

        binary_sensors = {} 
        binary_sensors = self.get_state('sensor')
        for binary_sensor in binary_sensors:
            temperature_level = binary_sensors[binary_sensor]['attributes'].get('battery_level', 101)
            if (temperature_level <= self._low_battery_level):
                devices.append(binary_sensor)
            temperature_numeric = binary_sensors[binary_sensor]['attributes'].get('Battery numeric', 101)*10
            if (temperature_numeric <= self._low_battery_level):
                devices.append(binary_sensor)
        self.log(devices)
        attributes = {}
        if len(devices) > 0:
            attributes['entity_id'] = devices # "[]{}".format(",".join(devices))
            self.log(attributes)
            self.set_state(entity_id='group.low_battery_sensors', state='on', attributes=attributes)

