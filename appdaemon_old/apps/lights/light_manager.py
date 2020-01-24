from typing import Tuple, Union

from base import Base
from globals import GlobalEvents


"""
Class LightManager, handle common light use-cases

- turn on/off ambiant ligts with remote, area listen to the event and act accordingly

"""


class LightManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()  # Always call base class

        self._remote_buttons_ambient_light = self.args.get(
            'remote_buttons_ambient_light', {})

        for remote_button_ambient_light in self._remote_buttons_ambient_light:
            self.listen_state(
                self.__on_ambient_light_button_pressed, remote_button_ambient_light)

    def __on_ambient_light_button_pressed(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        """called when ambient remote that button pressed on  controlls """
        if new == 'on':
            self.log("FIRE CMD_AMBIENT_LIGHTS_ON")
            self.fire_event(GlobalEvents.CMD_AMBIENT_LIGHTS_ON.value)
            self.log_to_logbook('Lights', "Ambient ligts on")
        else:
            self.log("FIRE CMD_AMBIENT_LIGHTS_OFF")
            self.fire_event(GlobalEvents.CMD_AMBIENT_LIGHTS_OFF.value)
            self.log_to_logbook('Lights', "Ambient ligts off")
            