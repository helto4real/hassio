# Dialog flow
This is the implementation of google DialogFlow.
Following use-cases are implemented
- Ask for current temperature
- Set car heater departure time
- Turn on car heater now and for 3 hours
- Turn off car heater now

## Configure dialog flow
I do not have detailed instructions how to create the flow but here is the basic things. *Make sure you use v2 of the API if you use my helper functions to parse json. And v1 if you use built in appdaemon ones.*

- [Login](https://console.dialogflow.com/) with your google account
- Create agent and seleft your language/es
- Click "Save"
- Go to "fullfillment" in the left menu
- Enable webhook and set your url to `https://yourhome.duckdns.org/api/appdaemon/yourappname?api_password=yourpassword` (remember to enalbe api_password in appdaemon)
- Create new "intent"
- Write a phrase that the user will tell dialog flow (below "user says"). Example `What temperature is it at home` (You can enter several versions of phrases, just use more rows)
- In action, set a key (this key will be the intent name) in appdaemon code later
- IMPORTANT, at end of pate enable "Fulfillment" and "Use webhook"
- Klick "Save"
- On the top rigth where is written "Try it now". Write or say your phrase you entered.

**Remember to open up in firewall, reverse proxy like nginx is recommended!!**

## The appdaemon app
### Appdaemon.yaml
Set the settings for appdaemon, like port and api key
Please see [dialogflow](dialogflow.py) for my implentation.

```
appdaemon:
  api_key: !secret appdaemon_key
  api_port: 5000
  threads: 10
...
```yaml

Create a class and the yaml for a appdaemon app. Register endpoint. 

```class DialogFlow(hass.Hass):
    """Proved dialog flow use-cases."""
    def initialize(self):
 
        self.register_endpoint(self.__api_call, 'dialogflow')
        
    def __api_call(self, data):
        intent = dlgflow_get_intent(data) # Use v2 
        param = dlgflow_get_parameter(data, 'date-time')
        return dlgflow_response("Hello world"), 200
        
```python

### Use the SSML tags
SSML is a way to make the language sound more natural in TTS. Please see [SSML](https://developers.google.com/actions/reference/ssml) docs at google for more details. Using the code is.

Se [dialogflow](dialogflow.py) implementation how I use it.
Example using sentences:
```
    return dlgflow_response("<p><s>Sentence one.</s><s>Sentence two. </s></p>"), 200
```python
