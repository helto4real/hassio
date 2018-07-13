import appdaemon.plugins.hass.hassapi as hass
from urllib.request import urlopen
import json
#
# Plays latest broadcast from Sveriges Radio with program id
#
# See http://api.sr.se/api/v2/episodes/getlatest?programid=4540&format=json&ondemandaudiotemplateid=8
#

class play_program(hass.Hass):

  def initialize(self):
     self.log("APP_SR_PROGRAM setting upp listen to event CMD_SR_PLAY_PROGRAM ")
     self.listen_event(self.my_callback, event = 'CMD_SR_PLAY_PROGRAM')
  
  def my_callback(self, CMD_SR_PLAY_PROGRAM, data, kwargs):
    programId = data.get('program_id') #"4540"
    entityId = data.get('entity_id')

    response = urlopen('http://api.sr.se/api/v2/episodes/getlatest?format=json&programid=' + programId)
    data = response.read().decode("utf-8")
    jsonData = json.loads(data)

    url = jsonData['episode']['broadcast']['broadcastfiles'][0]['url']
    
    self.log("URL: " + url)

    self.call_service("media_player/play_media", entity_id=entityId, media_content_type="audio/m4a", media_content_id=url)
    
