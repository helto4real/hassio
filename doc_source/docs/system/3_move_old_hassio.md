---
title: 3. Move old settings to new
summary: How to move old settings from old setup to new one
authors:
    - Tomas Hellström (@helto4real)
---

# Move old settings from current Hassio installation
Move a current installation is not as straight forward that one might home for. This is some of the stuff i figured out that could be of help if youre doing the same thing.

## Install backup from old HASSIO installation
- Get a backup and download it
- Login to your fresh copy of Hassio
- IMPORTANT! Before restoring backup, add the custom add-on paths to stores. If you not do this, the restore wont restore custom add-ons
- Make a restore of Hassio

## New IP for your machine
If your new machine has a new ip address additional things need to be taken care of. I choose to keep my old installation and start fresh i.e. new ip. The upside doing a new setup is that you can keep your old until everything is up and running.

- Do a "search in files" of all references of your old ip address and replace with new one.
- Few add-ons needs to be reconfigured by remove/add them again. Like the samba share. Copy the settings json to a textfile and reapply them after reinstall
- Deconz integration needs to be removed and readded (easiest path)
- Check `.storage` folder and the `config_entries`. You will can find references to old ip there. Replace with your new one

## Tip setting up your new machine
- I converted all my separate docker-compose files to a single one. I also used the shared folder as destination when i configure my volumes in docker, i.e. `/usr/share/hassio/share/docker/...`. That way my docker container data is always backed up in a hassio snapshot. 
