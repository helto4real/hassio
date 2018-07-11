#
# Base class for all applications in my home automations setup. 
# Thanks to https://github.com/bachya/smart-home/ for inspiration 
# of code design and some solutions
#
import appdaemon.plugins.hass.hassapi as hass
from globals import GlobalEvents, HouseModes

class Base(hass.Hass):
    """Define a base automation object."""

    def initialize(self) -> None:
        self.entities = self.args.get('entities', {})
        self.handles = {}  # type: ignore
        self.properties = self.args.get('properties', {})

        # Take every dependecy and create a reference to it:
        for app in self.args.get('dependencies', []):
            if not getattr(self, app, None):
                setattr(self, app, self.get_app(app))

class App(Base):
    """Define a base app object."""
    pass
    

