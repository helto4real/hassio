# MQTT Bluetooth presence docker image
This is the bluetooth precense detection through bluetooth. Checkout the https://github.com/andrewjfreyer/presence for details of usage. Thanks Andrew Freyer for your great work. 

This has been tested on intel nuc machines running linux but it could work on Raspberry PI too. 

You may or not need `sudo` before all commands in this setup, depending on your setup.

*Requirements*
- You need MQTT enabled on this or any host in your network
- Bluetooth enabled in hardware
- Bluetooth service disabled on host system (see Check host system)

## Installation
### Check host system

1. Check that bluetooth is enabled for your nuc hardware. 
2. Make sure the bluetooth service not running on the NUC. Easiest is to make sure service `bluetooth` not running. Depending on operating system, write `service --status-all` to or `systemctl status service_name`. If it is running, stop it and maker sure it don´t run at startup. (You would have to google for that one :) ) 

### Make docker image
1. Check the docker.compose.yaml file to see if you want to map the volumes differently. Change for your own pleasure.
2. Copy the content in the folder nuc_bluetooth to your device, as root type `docker-compose up -d'. Now it will build the image and and install the service
3. In the host volume you specified, change MQTT settings as specified in the file `mqtt_preferences`
4. Restart docker by running `docker-compose restart`
5. View log in portainer.io or write `docker logs hass_bluetooth --follow`to view the logs for errors 

### Configure devices to scan for
#### Finding MAC of your devices
1. Login as root 
2. Run the command `docker exec -it hass_bluetooth hcitool scan`
3. Turn bluetooth on/off on the device during scan make it faster to find the device. Use that mac address on screen 
#### Configure devices
1. Put the MAC addresses of the BT device in the `owner_devices` file 
2. Restart docker `docker-compose restart` or in portainer.io and check log i.e. `docker logs hass_bluetooth --follow` or in portainer.io. In the logs you can see the full `mqtt-topic` for the devices to put in the Home assistant config. 
#### Configure Home Assistant
See https://github.com/andrewjfreyer/presence and logs for the topic used.