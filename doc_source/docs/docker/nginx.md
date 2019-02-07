---
title: nginx and lets encrypt
summary: My documented Home Assistant configuration.
authors:
    - Tomas Hellström (@helto4real)
---
# Setup nginx, letsencrypt for improved security
I let you know my configuration to setup the reverse proxy (nginx) as a front with SSL for Home Assistant. My setup enables:
- Access Home Assistant with SSL from outside firewall through standard port and is routed to the home assistant on port 8123.
- Access Home Assistant from within the network (behind firewall) without SSL and using `http://ip:8123`
- In future expose more services on standard port 443 by extending nginx config

*DISCLAIMER: I dont take any responsibility that this configuration is 100% secure. It is more secure than not using a reverse proxy I would argue but I am not making any guarantees. I would recommend you read how to configure this your self*

Many would argue to improve security at a pro level is to use a real firewall with different v-lans for your devices and computers. This is not covered in this setup.

## Hass config
I use api password for security and ***not*** using `trusted_networks` for improved security. If you want to use `trusted_networks` I would not use a reverse proxy with `x_forwarded_for: True` config. There is a risk of hacking into hass by inserting the x_forwarded header without login!

I also enabled ip-ban and login attempts for even better security.

```yaml
http:
  api_password: !secret http_password
  ip_ban_enabled: True
  login_attempts_threshold: 3
  use_x_forwarded_for: True
```

## linuxserver/letsencrypt
Setup the linux server by using the provided docker-compose file. Mine is configured to listen to port 80/443 and I setup my routers portforwarding to point to the host, hosting this docker image. You will need the port 80 open to allow the letsecrypt to validate ownership of your domain. After that is completed and you get your certificates you can just leave the 80 closed and only forward 443 or any custom port you want to expose from the internet. Just make sure you change that in the compose-file.

Change the `domain.example` to your domain. If you use duckdns, use the whole address like `xyz.duckdns.org`. If you plan to expose several subdomains, use the `SUBDOMAINS` settings. At least expose the standard and `www`. But you might want to expose `grafana.expample.com`, just put `,grafana` there.

Copy the file and run `sudo docker-compose up -d` while on the same directory as the `docker-compose.yaml` file.

Check the log to make sure the certificates are created correctly.

## Setup nginx
First you want the ssl to configured to the correct certificates.

### 1. SSL certificates
You can see the paths in the log. The ssl config are at:
`/opt/letsencrypt/config/ngingx/ssl.conf` if you used my settings in docker-compose.yaml. Mine are in config folder (github) as reference.

```conf
# ssl certs
ssl_certificate /etc/letsencrypt/live/domain.example/fullchain.pem;
ssl_certificate_key /etc/letsencrypt/live/domain.example/privkey.pem;
```

### 2. Default server
Go to the folder `/opt/letsencrypt/config/nginx/site-confs` edit the `default`. See config folder here for reference.

All requests by default both on 80 and 443 is redirected to return 444. 

```yaml
server {
	listen 80;
	server_name _;
	return 444;
}

server {
	listen 443 ssl;
	server_name _;
	include /config/nginx/ssl.conf;
	return 444;

}
```
### 3. Hassio server
Now we make a new file in `/opt/letsencrypt/config/nginx/site-confs` called `hassio`.

The config is when you surf with domain.example (default 443) it routes it to your_hass_ip:8123. 

```yaml

map $http_upgrade $connection_upgrade {
   default upgrade;
   ''      close;
}

server {
    listen       443 ssl;
    server_name  domain.example;
    
    include /config/nginx/ssl.conf;
    
    proxy_buffering off;
    location / {
        proxy_pass ip_to_hass:8123;
        proxy_set_header Host $host;
        proxy_redirect http:// https://;
        proxy_http_version 1.1;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection $connection_upgrade;
    }

    location /api/websocket {
        proxy_pass ip_to_hass:8123/api/websocket;
        proxy_set_header Host $host;

        proxy_http_version 1.1;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection $connection_upgrade;

    }
}

```

## Router setup
Use your router to port forward 443 to the ip of nginx docker host. Remember to portforward port 80 to same host setting up letsecrypt. Then you can remove it once you have the domain ownership established.