---
title: 1. Setup the system - proxmox
summary: How to setup the hardware and proxmox and your hass VM.
authors:
    - Tomas Hellström (@helto4real)
---

# Setup the system
I use an Intel NUC as my device setting upp the system.
## Hardware
- Intel NUC with at least 8 Gig memory plus VM mem size, I use 32 Gig but 16 would be enough
- Make sure you have enough harddrive space. I use 256 gig SSD.
- Bios boot and hit F2 (NUC) to enter. Look for boot order and boot devices. Make sure USB boot is prio. Make sure you enabled virtualization features of the processor. 
## Prepare install
- Download the proxmox image at [this site](https://www.proxmox.com/en/downloads/category/iso-images-pve)
- Get a USB stick with at least 1 gig memory 
- Prepare the stick, I used [rufus download](https://rufus.ie/)
- Use the settings like below, specifically I used the DD mode (not ISO) to make the usb boot.

![rufus](img/proxmox/rufus_settings_1.jpg)

Set the DD setting (Pardon the Swedish) and press OK.
![rufus](img/proxmox/rufus_settings_2.jpg)
## Install
- Put the usb in the NUC and reboot. Make sure you made hardware and bios correctly
- Set the admin/root password (DONT LOSE IT!)
- Choose harddrive where you install proxmox on
- Select correct country, keyboard layout and time-zone
- Install and reboot after install is done
- Test install by login to proxmox web interface wich are https://yourip:8006. Login with root/yourpassword
## Configure before creating first VM
### Add the No-Subscription Repository
In order to get new images you need a repository. Give you have no subscription we have to add the correct repository. Add the pev-no-sybscription between the main contrib and security updates in the file:

`/etc/apt/sources.list`
```
deb http://ftp.debian.org/debian stretch main contrib

# PVE pve-no-subscription repository provided by proxmox.com,
# NOT recommended for production use
deb http://download.proxmox.com/debian/pve stretch pve-no-subscription

# security updates
deb http://security.debian.org stretch/updates main contrib
```
### Network
For home users the default bridged network makes most sense so not extra network is configured. Multiple bridges can be created. For improved security, vlans can be setup. I might do this in a test environmet but will not use VLAN for now.

### Certificates
I will use lets encrypt for certificate management. 
Todo: document this

## Add VM for Hassio
Creating the virtual machine. Default values apply if not specified in the instructions or on image.

### Upload the ISO
Download debian or what ever operating system you prefere. I use net install image of Debian 9. [download here](https://www.debian.org/CD/netinst/). Select amd64 CD or torrent if you prefer.

![upload](img/proxmox/upload_iso.jpg)

Then select your ISO file and press `Upload`

![upload](img/proxmox/upload_iso_debian.jpg)

### Add the VM
**General**
- Name: HASSIO
- No resource pool

![general](img/proxmox/1-create-vm-general.jpg)

**OS**
- select your isofile and use rest default

![general](img/proxmox/create-vm-deb.jpg)

**Hard disk**
I used 20 Gig as start disk, remember that the whole disk wont be allocated at once. This is the max size.

**CPU**
- 1 socket, 2 cores should be sufficent (I have 4 cores total)

**Memory**
- 2368 MiB should be sufficient for HASSIO and docker containers

**Network**

Default settings

Create the VM by select the start the installation after created checkbox and press "Finish"

### Setup Debian
#### Installation
For other operating systems please see other.
- double click on new host to get to screen
- Install Debian with default settings. I used swedish as language and sweden as location 
- Choose host name, I use hassio
- Set the root password
- Set the non root name and username 
- Use whole disk and standard settings for partitioning
- Use standard settings util you are at the software selection
- Unselect debian environment and print server
- Select "SSH" server, I am sure you want to connect remote to the machine
- Install rest as default and reboot

Screens from setup. (Sorry for Swedish):

![general](img/proxmox/debian_start.jpg)
![general](img/proxmox/debian_language.jpg)
![general](img/proxmox/debian_host.jpg)
![general](img/proxmox/debian_software.jpg)



#### Install sudo
Depending on your configuration you might need to install sudo.

Enter su using `$ su` and enter password.
Install sudo and add your user (the one you provided in installtime) and exit from su.
```
$ apt-get install sudo
$ adduser username sudo
$ usermod -aG sudo youruser
$ exit
``` 
and the exit. 
Now you can use sudo for admin. 

if you get problems you might need to add the user in the sudoers file.

```
$ su
$ nano /etc/sudoers
$ exit
``` 
put the `youruser   ALL=(ALL:ALL) ALL` after root

#### IP configuration
If you want the default DHCP IP just skip this step

```
# Log in as root or su to root then
nano /etc/network/interfaces
# Should look like this:
source /etc/network/interfaces.d/*
# The loopback network interface
auto lo
iface lo inet loopback
# The primary network interface
allow-hotplug eth0
iface eth0 inet dhcp
```
then change to :

```
# The primary network interface
allow-hotplug eth0
iface eth0 inet static
        address 192.168.1.202
        netmask 255.255.255.0
        gateway 192.0.1.1
```
Make sure your settings are correct. In an VM the eth0 is probable something else. To list network interfaces write `ip link show` to get the correct one. You need to select the ethernet interface.

#### Finalizing the setup
Now it is a good time to make a snapshot. A snapshot is a point in time to restart from. 
- First make sure the latest updates and uppgrades are on the base operating syste before making snapshot.

```
$ sudo apt-get update
$ sudo apt-get upgrade
$ exit
``` 

go to the proxmox web interface and select your host ant then select "snapshot".
Create the snapshot. Call it "Fresh". Now we always can start fresh after installing hassio and all other stuff.

CONGRATULATIONS YOUR FIRST VM IS UP AND RUNNING!

# Proxmox backup
One of the best features running virtual environments is the possibility to backup entire machine really easy. Here is docs about how that's done.
## Use usb disk
### Mount the USB drive
If you are running a windows system, the drive is probably a NTFS drive. This guide assumes this but there are basically very few difference with other format types. 

For full descriptions go to [this url](https://linuxconfig.org/howto-mount-usb-drive-in-linux)

1. `$ fdisk -l` lists your disks, make sure you can see your drive. Take not of drive path i.e. `/dev/?`
2. `$ mkdir /media/usb-drive` makes mount point
3. `$ mount /dev/sdc1 /media/usb-drive/` (sdc1 will probably be another device id for you), check #1
4. `$ mount | grep sdc1`, to check if mount went ok

if you later want to unmount the usb, the command is `umount /media/usb-drive`. 

To PERMANENTLY MAKE MOUNT AVAILABLE ATT BOOT then do following. 

1. `$ blkid -t TYPE=ntfs -sUUID` Check your unique id of drive. The type can be `vfat` if not windows formatted.
2. In the file `/etc/fstab` add the following `UUID=702432D524329DD2 /media/usb-drive ntfs defaults 0 0` REMEMBER TO USER YOUR OWN UUID and other type than ntfs if your drive is formatted non ntfs! 

**Please be VERY CAREFUL to make sure everything is correct. This is why you should try mount manually first** 

### Add drive to Proxmox
1. In datacenter view, select `Storage`
2. Click, "Add->Directory" set your settings and Save

![directory](img/proxmox/storage_create_directory.jpg)

Now you can use the drive as target disk making backups in proxmox!.

## Schedule backups
1. In datacenter view, select `Backup`
2. Add a backupscheme and select your new backupdisk

![backup](img/proxmox/add_backup.jpg)
