# import datetime
# from enum import Enum
# from typing import Tuple, Union
# import json
# from urllib.request import urlopen
# import smhi
# #Have to copy the base.py too from my repository or replace SMHISensor(App) with SMHISensor(hass.Hass)
# from base import App

# """
#     Reads the current data from swedish weather institute (SMHI) and
#     puts in a sensor
# """
# class SMHISensor(App):
    
#     def initialize(self) -> None:
#         """Initialize."""
#         super().initialize()
#         self._longitude = self.args.get('longitude', str)
#         self._latitude = self.args.get('latitude', str)
        
#         self._smhi = smhi.Smhi(self._longitude, self._latitude)
        
   
#     def __get_lastest_forecast(self) -> None:
#         """Gets latest json forecast and creates/updates the sensor."""

#         attributes = {}

#         for forecast in self._smhi.get_forecast():
            
#             attributes['temperature'] = forecast.temperature
#             attributes['pressure'] = forecast.pressure
#             attributes['thunder'] = forecast.thunder
#             attributes['cloudiness'] = forecast.cloudiness
#             attributes['symbol'] = forecast.symbol

#         self.log(attributes)
