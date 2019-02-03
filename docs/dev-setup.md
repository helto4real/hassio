# My development setup of homeassistant
This is my setup when I develop in home assistant. Instead of using the setup provided in the normal docs I instead enjoy the usage of docker isolation for projects. Thanks to @thomasloven for the inspiration doint this. If youre looking for front-end dev, check out [@thomasloven docs.](https://github.com/thomasloven/hass-config/wiki/Dev-Setup)

**These examples might require you need to write `sudo` before any command in prompt!**

## Setup your devbranch
1. Make a single folder where your devstuff will be. 
3. make a folder called `config`
4. Make a fork of the home assistant 
Go to [home assistant on github](https://github.com/home-assistant/home-assistant) and make a fork.
5. In your root dev folder you just created

```
$ git clone https://github.com/YOUR_GIT_USERNAME/home-assistant.git
$ cd home-assistant
$ git remote add upstream https://github.com/home-assistant/home-assistant.git
```
5. Create a new branch
```
$ git checkout -b [your branch name]
```
6. When youre ready to make PR push the branch. *The first git push command only have to be done once*

```
$ git push --set-upstream origin [your branch name]
```
After set upstream once you can only do to push commits to your fork
```
$ git push origin
```
7. If your fork is old start with refresh the files from dev branch from upstream
```
$ sudo git pull --rebase upstream dev
```

Now you can code at a good point

## Setup docker-compose
1. make the `docker-compose.yaml` file like below:

```yaml

version: '3'
services:
  hass:
    container_name: homeassistant-hass
    image: homeassistant/home-assistant:dev
    volumes:
      - ./home-assistant:/usr/src/app
      - ./config:/config
    environment:
      TS: Europe/Stockholm # adjust this to your liking, obviously
    #restart: always # This one you probably now want
    ports:
      - "8123:8123"

```
2. Run the `docker-compose up` once to create the config files in your folder. `ctrl+c` to exit hass.

## Start the hass from command prompt
If you want to run hass from command prompt, use the `docker-compose run` command. The `--service-ports` makes docker expose the ports defined in the compose file.
```
$ docker-compose run --rm --service-ports hass /bin/bash
```
To start home assistant from the prompt:
```
$ python -m homeassistant --config /config
```

## Testing code
To run the tests you need to install tox in the container. 
```
$ apt-get update && \
    apt-get install -y --no-install-recommends locales-all && \
    apt-get clean && rm -rf /var/lib/apt/lists/* /tmp/* /var/tmp/*

$ pip3 install --no-cache-dir tox
```

# Make own dev image
If you don't want to install tox every time you run docker-compose, make your own image.

**Make sure you recreate this image now and then to get the latest updates!**

1. From the homeassistant docker file, make your own dev image
```
docker build -t helto4real/home-assistant:dev .
```
2. In your dev root folder make a `Dockerfile.dev` like
```dockerfile
FROM helto4real/home-assistant:dev

RUN apt-get update && \
    apt-get install -y --no-install-recommends locales-all && \
    apt-get clean && rm -rf /var/lib/apt/lists/* /tmp/* /var/tmp/*

RUN pip3 install --no-cache-dir tox

CMD [ "python", "-m", "homeassistant", "--config", "/config" ]
```
and run:
```
$ docker build -t helto4real/home-assistant-dev:dev -f Dockerfile.dev .
```
ether change the docker-compose file above to use `helto4real/home-assistant-dev:dev` instead 

