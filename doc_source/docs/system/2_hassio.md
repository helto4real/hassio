---
title: 2. Setup the system - Hassio
summary: How to setup Hassio on Debian (Umbuntu might work). Will also setup docker-compse
authors:
    - Tomas Hellström (@helto4real)
---
# Install prereq and hassio
This script requires a clean machine. It will install docker and hassio.
Copy and paste the following script prior installing hassio.

FIRST GO INTE SUDO MODE IF YOU HAVE SUDO!!!

```
sudo -i
```
Then copy following script!

```
apt-get update &&\
apt-get install -y \
    apt-transport-https \
    ca-certificates \
    curl \
    gnupg2 \
    software-properties-common &&\
curl -fsSL https://download.docker.com/linux/debian/gpg | sudo apt-key add - &&\
add-apt-repository \
    "deb [arch=amd64] https://download.docker.com/linux/debian \
    $(lsb_release -cs) \
    stable" &&\
apt-get update &&\
apt-get install -y docker-ce docker-ce-cli containerd.io &&\
curl -L "https://github.com/docker/compose/releases/download/1.23.2/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose &&\
sudo chmod +x /usr/local/bin/docker-compose &&\
apt-get install -y apparmor-utils apt-transport-https avahi-daemon ca-certificates curl dbus jq network-manager &&\
curl -sL "https://raw.githubusercontent.com/home-assistant/hassio-build/master/install/hassio_install" | bash -s

```