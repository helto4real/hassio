
"""Implement scenes from Google Home/Assistant.

This is a way to easily invoke automations from google home using scenes.
"""
from enum import Enum
from typing import Tuple
from base import Base
from globals import HouseModes
import appdaemon.plugins.hass.hassapi as hass

class SceneAutomations(Base):
    """Proved dialog flow use-cases."""
    def initialize(self) -> None:
        #self.listen_state(self.__on_scene_changed, entity='scene')
        self.listen_event(self.__on_scene_changed, "call_service", service = "turn_on", domain = "scene")

    # def __on_scene_changed(self, entity: str, old: str, new: str)->None:
    #     self.log("SCENE: {}".format(new))

    def __on_scene_changed(self, event_name, data, kwargs):
        _,scene = data['service_data']['entity_id'].split('.')
        self.log_to_logbook('Scenes', "Scen ändrad till {}".format(scene))       
        self.log("SCENE: {}".format(scene))
        if scene == 'natt':
            self.set_state(entity_id='input_select.house_mode_select', state=HouseModes.night.value)
        elif scene == 'morgon':
            self.set_state(entity_id='input_select.house_mode_select', state=HouseModes.morning.value)
        elif scene == 'kvall':
            self.set_state(entity_id='input_select.house_mode_select', state=HouseModes.evening.value)
        elif scene == 'dag':
            self.set_state(entity_id='input_select.house_mode_select', state=HouseModes.day.value)
        elif scene == 'stadning':
            self.set_state(entity_id='input_select.house_mode_select', state=HouseModes.cleaning.value)
