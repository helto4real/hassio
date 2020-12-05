# My development setup
This is my setup for doing development on home assistant. The remote features of VS.code is awesome and now when Home Assistant docker container is built upon startup it is a plug&play experience thanks to @pvizeli.

# Development of Hass
## Components 
- PC: Any type of PC that are able to run linux containers
- VSCODE (Visual Studio Code)
- [Remote Development extension](https://code.visualstudio.com/docs/remote/remote-overview) installed on VSCODE
- GIT 

## Home assistant remote debugging
Make sure you install the remote debugger component "ptvsd" in hass. Then start hass from the home-assistant folder, the root. Also make sure you open the remote folder the same. Se rest of config for remote debugging.

Typically I do the following steps:

1. Clone your fork repo of Home Assistant as described in [devdocs](https://developers.home-assistant.io/docs/en/development_environment.html#setup-local-repository)
2. Open the folder "Home-Assistant" in VSCODE, now you will be prompted if you want to use the container, and you want that :)
3. Now it starts new instance of VSCODE and builds container
4. From terminal you can go to homeassistant folder and start hass as usual with "hass" 
5. Use localhost:8123 to access


### Remote debugging component
In the configuration.yaml file, add the ptvsd component. You can open the file on /root/.homeassistant/configuration.yaml from VSCODE remote container and add:
```yaml
ptvsd:
  wait: True # Set to True if you want hass to break and wait for debugger to attach
```
### Remote python debug setup in VSCODE
Make sure you setup python remote attach debugger that should look something like this. Make sure the "justMyCode" is false or the breakpoint will not be working correctly.

```json
{
            "name": "Python: Remote Attach",
            "type": "python",
            "request": "attach",
            "justMyCode": false,
            "port": 5678,
            "host": "localhost",
            "pathMappings": [
                {
                    "localRoot":  "/workspaces/home-assistant/homeassistant",
                    "remoteRoot": "."
                }
            ]
        }
```





