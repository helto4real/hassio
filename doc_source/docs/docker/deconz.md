---
title: Deconz
---
# Setup deconz in docker
As many users of Hass.io you will have several serial devices but the deconz requires the devices to be ttyUSB0 for conbee stick. Here is a trick to manage this.

## Make presistent device names
Check this [guide](http://hintshop.ludvig.co.nz/show/persistent-names-usb-serial-devices/) for details.


**First find out what device id you have for your serial devices**

If you know which device you want to get details about, run
```sh
$ /bin/udevadm info --name=/dev/ttyUSB0 | grep ID_VENDOR
E: ID_VENDOR_ID=0403

$ /bin/udevadm info --name=/dev/ttyUSB0 | grep ID_MODEL_ID
E: ID_MODEL_ID=6015

$ /bin/udevadm info --name=/dev/ttyUSB0 | grep SERIAL_SHORT
E: ID_SERIAL_SHORT=ABC01234
```

```
$ lsusb

Bus 002 Device 004: ID 0403:6015 Future Technology Devices International, Ltd Bridge(I2C/SPI/UART/FIFO)
Bus 002 Device 003: ID 0403:6001 Future Technology Devices International, Ltd FT232 USB-Serial (UART) IC
```
One of the two devices is my conbee device have to find out which.

Look for something similar to below to find your conbee device
```
$ more /var/log/messages | grep ttyUSB -B 7 -A 7

New USB device found, idVendor=0403, idProduct=6015
Product: FT230X Basic UART
Manufacturer: FTDI
SerialNumber: DO00KDGR

```

**Make UDEV rules**
create a file at: /etc/udev/rules.d/99-usb-serial.rules
Make sure your id:s and serial number matches!

```
SUBSYSTEM=="tty", ATTRS{idVendor}=="0403", ATTRS{idProduct}=="6015", ATTRS{serial}=="DO00KDGR", SYMLINK+="ttyUSB.CON"
SUBSYSTEM=="tty", ATTRS{idVendor}=="0403", ATTRS{idProduct}=="6001", ATTRS{serial}=="A138UEXZ", SYMLINK+="ttyUSB.RFX"
```

restart and you will have two new devices ttyUSB.CON and ttyUSB.RFX that will be correctly mapped every time. 
check with ``ls /dev`` and check link with ``ls -l /dev/ttyUSB.CON``
In my example I use rfxtrx usb too.

## Starting the deconz docker container

Now you can map ttyUSB.CON to ttyUSB0 as the example below... And youre done!

```shell-script

$ sudo docker run -d \
    --name=deconz \
    --net=host \
    --restart=always \
    -e DECONZ_WEB_PORT=8080 \
    -e DECONZ_WS_PORT=8443 \
    -v /opt/deconz:/root/.local/share/dresden-elektronik/deCONZ \
    --device=/dev/ttyUSB.CON:/dev/ttyUSB0 \
    marthoc/deconz

```

or 

use my docker compose file in this folder
```yaml

version: "2"
services:
  deconz:
    image: marthoc/deconz
    container_name: deconz
    network_mode: host
    restart: always
    volumes:
      - /opt/deconz:/root/.local/share/dresden-elektronik/deCONZ
    devices:
      - /dev/ttyUSB.CON:/dev/ttyUSB0
    environment:
      - DECONZ_WEB_PORT=8080
      - DECONZ_WS_PORT=8443
      - DEBUG_INFO=1
      - DEBUG_APS=0
      - DEBUG_ZCL=0
      - DEBUG_ZDP=0
      - DEBUG_OTAU=0

```