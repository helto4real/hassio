---
title: 3.1 Alternative hassos install
summary: How to move old settings from old setup to new one
authors:
    - Tomas Hellström (@helto4real)
---

# Alternative way to install Hassio
After my initial setup I found out there are possible to install Hassio directly as VM on proxmox using hassos!
My strategy is to make local add-ons for any docker container I need for Home Assistant. In that way I can keep the server footprint very small and have "all-in-one" package to backup both hassio config plus VM.

See  [whisker hassos install script](https://github.com/whiskerz007/proxmox_hassos_install) for instructions. This script apply for proxmox. 

## Warning!
If you use several hassio instances on the same machine, disable discovery for yeelight on all but one. There are a bug that makes hass loop 100% cpu. 
