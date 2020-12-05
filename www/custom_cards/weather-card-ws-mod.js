customElements.whenDefined('weather-card').then(() => {

  class WeatherCardWindSpeedMod extends customElements.get('weather-card') {
      render() {
        if (!this._config || !this.hass) {
          return html``;
        }
    
        const stateObj = this.hass.states[this._config.entity];
    
        if (!stateObj) {
          return html`
            <style>
              .not-found {
                flex: 1;
                background-color: yellow;
                padding: 8px;
              }
            </style>
            <ha-card>
              <div class="not-found">
                Entity not available: ${this._config.entity}
              </div>
            </ha-card>
          `;
        }
    
        const lang = this.hass.selectedLanguage || this.hass.language;
    
        const next_rising = new Date(
          this.hass.states["sun.sun"].attributes.next_rising
        );
        const next_setting = new Date(
          this.hass.states["sun.sun"].attributes.next_setting
        );
    
        return html`
          ${this.renderStyle()}
          <ha-card @click="${this._handleClick}">
            <span
              class="icon bigger"
              style="background: none, url(${
                this.getWeatherIcon(
                  stateObj.state.toLowerCase(),
                  this.hass.states["sun.sun"].state
                )
              }) no-repeat; background-size: contain;"
              >${stateObj.state}
            </span>
            ${
              this._config.name
                ? html`
                    <span class="title"> ${this._config.name} </span>
                  `
                : ""
            }
            <span class="temp"
              >${
                this.getUnit("temperature") == "°F"
                  ? Math.round(stateObj.attributes.temperature)
                  : stateObj.attributes.temperature
              }</span
            >
            <span class="tempc"> ${this.getUnit("temperature")}</span>
            <span>
              <ul class="variations">
                <li>
                  <span class="ha-icon"
                    ><ha-icon icon="mdi:water-percent"></ha-icon
                  ></span>
                  ${stateObj.attributes.humidity}<span class="unit"> % </span>
                  <br />
                  <span class="ha-icon"
                    ><ha-icon icon="mdi:weather-windy"></ha-icon
                  ></span>
                  ${
                    windDirections[
                      parseInt((stateObj.attributes.wind_bearing + 11.25) / 22.5)
                    ]
                  }
                  ${ Math.round( stateObj.attributes.wind_speed/3.6 * 10 ) / 10}<span class="unit">
                  m/s
                  </span>
                  <br />
                  <span class="ha-icon"
                    ><ha-icon icon="mdi:weather-sunset-up"></ha-icon
                  ></span>
                  ${next_rising.toLocaleTimeString()}
                </li>
                <li>
                  <span class="ha-icon"><ha-icon icon="mdi:gauge"></ha-icon></span
                  >${stateObj.attributes.pressure}<span class="unit">
                    ${this.getUnit("air_pressure")}
                  </span>
                  <br />
                  <span class="ha-icon"
                    ><ha-icon icon="mdi:weather-fog"></ha-icon
                  ></span>
                  ${stateObj.attributes.visibility}<span class="unit">
                    ${this.getUnit("length")}
                  </span>
                  <br />
                  <span class="ha-icon"
                    ><ha-icon icon="mdi:weather-sunset-down"></ha-icon
                  ></span>
                  ${next_setting.toLocaleTimeString()}
                </li>
              </ul>
            </span>
            ${
              stateObj.attributes.forecast &&
              stateObj.attributes.forecast.length > 0
                ? html`
                    <div class="forecast clear">
                      ${
                        stateObj.attributes.forecast.slice(0, 5).map(
                          daily => html`
                            <div class="day">
                              <span class="dayname"
                                >${
                                  new Date(daily.datetime).toLocaleDateString(
                                    lang,
                                    {
                                      weekday: "short"
                                    }
                                  )
                                }</span
                              >
                              <br /><i
                                class="icon"
                                style="background: none, url(${
                                  this.getWeatherIcon(daily.condition.toLowerCase())
                                }) no-repeat; background-size: contain;"
                              ></i>
                              <br /><span class="highTemp"
                                >${daily.temperature}${
                                  this.getUnit("temperature")
                                }</span
                              >
                              ${
                                typeof daily.templow !== 'undefined'
                                  ? html`
                                      <br /><span class="lowTemp"
                                        >${daily.templow}${
                                          this.getUnit("temperature")
                                        }</span
                                      >
                                    `
                                  : ""
                              }
                              <br /><span class="lowTemp">
                                ${daily.precipitation}${
                                    this.getUnit("precipitation")
                                }</span>
                            </div>
                          `
                        )
                      }
                    </div>
                  `
                : ""
            }
          </ha-card>
        `;
      }
      renderStyle() {
        return html`
          <style>
            ha-card {
              cursor: pointer;
              margin: auto;
              padding-top: 2.5em;
              padding-bottom: 1.3em;
              padding-left: 1em;
              padding-right: 1em;
              position: relative;
            }
    
            .clear {
              clear: both;
            }
    
            .ha-icon {
              height: 18px;
              margin-right: 5px;
              color: var(--paper-item-icon-color);
            }
    
            .title {
              position: absolute;
              left: 3em;
              top: 0.6em;
              font-weight: 300;
              font-size: 3em;
              color: var(--primary-text-color);
            }
            .temp {
              font-weight: 300;
              font-size: 4em;
              color: var(--primary-text-color);
              position: absolute;
              right: 1em;
              top: 0.3em;
            }
    
            .tempc {
              font-weight: 300;
              font-size: 1.5em;
              vertical-align: super;
              color: var(--primary-text-color);
              position: absolute;
              right: 1em;
              margin-top: -14px;
              margin-right: 7px;
            }
    
            .variations {
              display: flex;
              flex-flow: row wrap;
              justify-content: space-between;
              font-weight: 300;
              color: var(--primary-text-color);
              list-style: none;
              margin-top: 4.5em;
              padding: 0;
            }
    
            .variations li {
              flex-basis: auto;
            }
    
            .variations li:first-child {
              padding-left: 1em;
            }
    
            .variations li:last-child {
              padding-right: 1em;
            }
    
            .unit {
              font-size: 0.8em;
            }
    
            .forecast {
              width: 100%;
              margin: 0 auto;
              height: 10.6em;
            }
    
            .day {
              display: block;
              width: 20%;
              float: left;
              text-align: center;
              color: var(--primary-text-color);
              border-right: 0.1em solid #d9d9d9;
              line-height: 2;
              box-sizing: border-box;
            }
    
            .dayname {
              text-transform: uppercase;
            }
    
            .forecast .day:first-child {
              margin-left: 0;
            }
    
            .forecast .day:nth-last-child(1) {
              border-right: none;
              margin-right: 0;
            }
    
            .highTemp {
              font-weight: bold;
            }
    
            .lowTemp {
              color: var(--secondary-text-color);
            }
    
            .icon.bigger {
              width: 10em;
              height: 10em;
              margin-top: -4em;
              position: absolute;
              left: 0em;
            }
    
            .icon {
              width: 50px;
              height: 50px;
              margin-right: 5px;
              display: inline-block;
              vertical-align: middle;
              background-size: contain;
              background-position: center center;
              background-repeat: no-repeat;
              text-indent: -9999px;
            }
    
            .weather {
              font-weight: 300;
              font-size: 1.5em;
              color: var(--primary-text-color);
              text-align: left;
              position: absolute;
              top: -0.5em;
              left: 6em;
              word-wrap: break-word;
              width: 30%;
            }
          </style>
        `;
      }
  }
  customElements.define("weather-card-ws-mod", WeatherCardWindSpeedMod);
});
