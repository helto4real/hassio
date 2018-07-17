from base import Base
from base import GlobalEvents
import struct, socket
from typing import Tuple, Union
from urllib.request import urlopen
import uuid
"""
Class ComputerManager manage a pc in the network

Features:

- Creates a switch that turns on / hibernates PC
- Updates the switch status

"""
class ComputerManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class
        self._computers = self.args.get('computers', {})

        self.__init_state() 

        for computer in self._computers:
            switch_name = self.__get_switch_name(computer)
            self.log(switch_name)
            self.listen_state(
                self.__on_computer_state_changed, 
                switch_name) #,
                #computer = computer)

    def __on_computer_state_changed(
            self, entity: Union[str, dict], attribute: str, old: dict,
            new: dict, kwargs: dict) -> None:
        """called when computer switch change state"""
        self.log("NEW{} OLD{}".format(new,old))
        if new == old or old == None:
            return

        if new == 'on':
            self.__turn_on_computer(kwargs['computer'])
        else:
            self.__turn_off_computer(kwargs['computer'])   

    def __turn_on_computer(self, computer:str)->None:
        if self.__computer_is_awake(computer):
            return #Already awake
        
        # Turn on the computer to wake up on lan
        mac_address = self._computers[computer]['mac']
        self.__wake_on_lan(mac_address)

    def __turn_off_computer(self, computer:str)->None:
        # Turn off the computer using utility "sleeponlan" https://github.com/SR-G/sleep-on-lan
        response = urlopen("http://{}:8009/sleep".format(self._computers[computer]['ip']))
        self.log("TURNING OFF COMUTER {}".format(computer))
    def __wake_on_lan(self,ethernet_address)->None:

        # Construct a six-byte hardware address
        addr_byte = ethernet_address.split(':')
        hw_addr = struct.pack('BBBBBB', int(addr_byte[0], 16),
            int(addr_byte[1], 16),
            int(addr_byte[2], 16),
            int(addr_byte[3], 16),
            int(addr_byte[4], 16),
            int(addr_byte[5], 16))

        # Build the Wake-On-LAN "Magic Packet"...

        msg = 'xff' * 6 + hw_addr * 16

        # ...and send it to the broadcast address using UDP

        s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        s.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
        s.sendto(msg, ('', 9))
        s.close()
    
    def __computer_is_awake(self, computer:str)->bool:
        try:
            response = urlopen("http://{}:8009".format(self._computers[computer]['ip']), timeout=1)
            return True
        except:
          #  _LOGGER.warn("Error reading:" + sys.exc_info()[0])
            return False

    def __get_switch_name(self, computer:str)->str:
        return "switch.pc_{}".format(computer)

    def __init_state(self):
        for computer in self._computers:
            switch_name = self.__get_switch_name(computer)
            self.log("entity exists {} = {}".format(switch_name, self.entity_exists(switch_name)))
            attributes = {}
            attributes['icon']='mdi:desktop-classic'
            unique_id = "pc-{}".format(self._computers[computer]['mac'])
            attributes['unique_id'] = unique_id
            attributes['id'] = uuid.uuid4().hex
            if self.__computer_is_awake(computer):
                self.set_state(entity_id=switch_name,id=uuid.uuid4().hex, unique_id=unique_id, platform='custom-pc', config_entry_id=uuid.uuid4().hex, state = 'on', attributes=attributes)
            else:
                self.set_state(entity_id=switch_name,id=uuid.uuid4().hex, unique_id=unique_id, platform='custom-pc', config_entry_id=uuid.uuid4().hex, state = 'off', attributes=attributes)
            


        
