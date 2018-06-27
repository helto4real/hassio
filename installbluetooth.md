# Install bluetooth

apt install bluetooth

Scan the bluetooth devices
``hcitool scan``


docker run -it --rm --net=host --privileged helto/bluetooth_nuc  /bin/bashe