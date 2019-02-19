customElements.whenDefined('hui-weather-forecast-card').then(() => {

    class SmhiForecastCard extends customElements.get('hui-weather-forecast-card') {
        set hass(hass) {
            super.hass = hass
            this.lastChild.getWindSpeed = function(speed) {
                return `${ Math.round( speed/3.6 * 10 ) / 10} m/s`;
            }
        }
    }
    customElements.define("smhi-forecast-card", SmhiForecastCard);
});