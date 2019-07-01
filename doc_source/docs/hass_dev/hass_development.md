# My development setup
This is my setup for doing development on home assistant. The remote features of VS.code is somewhat experimental so use at own risk. Currently VS.code experimental only supports remote development and debugging.

# Development of Hass
## Components 
- Home Assistant host: Any linux machine or VM
    - Debian/Ubuntu 
    - Git
    - Python environment including venv
- Develop tools: Windows PC with VSCODE

I use a LXC container with debian 9 as host for my dev environment running on proxmox. But any linux based host would suffice. Using docker containers on dev machine would also work. You will need the docker remote extension for VSCODE then.

I use my PC as development machine i.e where my VSCODE is installed.  Setup SSH on the dev server and use root or other user as you please. Make sure your settings are right by do a manual ssh session. 

## VS.Code Extension
You will need the "Remote - SSH" extension for Visual Studio Code Eperimental on your dev maching/laptop.  Install it through normal extension add-ons in VS Code. 
[Check out the docs](https://github.com/Microsoft/vscode-remote-release)

I recommend using public/private key to access rather than a username/password. Please checkout the [Microsoft docs for this](https://code.visualstudio.com/docs/remote/troubleshooting#_installing-a-supported-ssh-client)


## Home assistant remote debugging
Make sure you install the remote debugger component "ptvsd" in hass. Then start hass from the home-assistant folder, the root. Also make sure you open the remote folder the same. Se rest of config for remote debugging.

Typically I do the following steps:

1. Devmachine: Remote SSH to the devenvironment using ssh client
2. Devserver: Activate the correct venv with source command
3. Devserver: Start Hass in the root git folder att devserver
4. Devmachine: In VSCODE, press F1 and choose `Remote-SSH: Connect to Host`
5. Devmachine: Attach debugger 
6. Devmachine: Fly away!!! 

### Remote debugging component
In the configuration.yaml file, add the ptvsd component. Remember to remove in production environment.
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
            "debugStdlib": true,
            "port": 5678,
            "host": "localhost",
            "pathMappings": [
                {
                    "localRoot":  "${workspaceRoot}",
                    "remoteRoot": "."
                }
            ]
        }
```





