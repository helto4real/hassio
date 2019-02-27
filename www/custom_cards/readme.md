# Custom cards
Here my custom cards are for lovelace. My own cards are packaged source code in the custom-cards.js file.

See repo https://github.com/helto4real/hassio-custom-cards for full source source code. There are dockumention there as well how to setup dev/build environment.

## Weather card
Thanks to [@bramkragten](https://github.com/bramkragten/custom-ui/tree/master/weather-card) for the original card. i mod it to support precipitation and use m/s as meassurment for wind speed.

Copy the weather icons (weather_icons folder) and weather-card.js

use following in lovelace yaml

```yaml
- type: custom:weather-card
        entity: weather.smhi_hemma        
        icons: "/local/custom_cards/weather_icons/"
```