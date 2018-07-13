import appdaemon.plugins.hass.hassapi as hass
from urllib.request import urlopen
import json
#
# Plays latest broadcast from Sveriges Radio with program id
#
# See http://api.sr.se/api/v2/episodes/getlatest?program_id=4540&format=json&ondemandaudiotemplateid=8
#

class play_program(hass.Hass):

  def initialize(self)->None:
    """Initializer"""
    
    self.log("APP_SR_PROGRAM setting upp listen to event CMD_SR_PLAY_PROGRAM ")
    self.listen_event(self.__on_cmd_sr_play_program, event = 'CMD_SR_PLAY_PROGRAM')
  
  def __on_cmd_sr_play_program(self, CMD_SR_PLAY_PROGRAM, data, kwargs)->None:
    """We got an event to play a program"""
    program_id = data.get('program_id') #"4540"
    entity_id = data.get('entity_id')

    response = urlopen('http://api.sr.se/api/v2/episodes/getlatest?format=json&program_id=' + program_id)
    data = response.read().decode("utf-8")
    json_data = json.loads(data)

    url = json_data['episode']['broadcast']['broadcastfiles'][0]['url']

    self.call_service("media_player/play_media", entity_id=entity_id, media_content_type="audio/m4a", media_content_id=url)
    
