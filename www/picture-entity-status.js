/*
    Custom card to display presence information on a image.
    The style is optimized for my specific height running 4xtiles horisontally

    if you want to change nr of tiles, change the scale variable to greater value than 50px, 100px for two tiles, 75 for 3 maybe
        if (!cardConfig.scale) cardConfig.scale = "50px";
    then adjust the css as you have to to compensate for size change. Sorry for this hard coded stuff but i suck at javascript and HTML5 :)

      - type: custom:picture-entity-status
        entity: sensor.presence_tomas
        image: /local/tomas_presence_away.jpg #standard image for away
        state_image:
            Home: /local/tomas_presence.jpg             # for each state specify image
            Just arrived: /local/tomas_presence.jpg     # for each state specify image
            
*/


class PictureEntityStatus extends HTMLElement {
    constructor() {
        super();
        this.attachShadow({ mode: 'open' });
    }
  setConfig(config) {
    if (!config.entity) {
        throw new Error('Please define an entity');
    }

    const root = this.shadowRoot;
    if (root.lastChild) root.removeChild(root.lastChild);

    const cardConfig = Object.assign({}, config);
    
    if (!cardConfig.scale) cardConfig.scale = "50px";
    if (!cardConfig.min) cardConfig.min = 0;
    if (!cardConfig.max) cardConfig.max = 100;

    const card = document.createElement('ha-card');
    const shadow = card.attachShadow({ mode: 'open' });
    const content = document.createElement('div');
    const style = document.createElement('style');

    content.innerHTML = `
    <div class="container" id="container">
        <div id="image"></div>
        <div id="shadow"></div>
        <div id="title">Home</div>
    </div>
    `;

    style.textContent = `
        ha-card {
        --base-unit: ${cardConfig.scale};
        height: calc(var(--base-unit)*2);
        position: relative;
        }
        .container{
        width: calc(var(--base-unit) * 2.42);
        height: calc(var(--base-unit) * 2.0);
        position: absolute;
        top: 0px;
        
        overflow: hidden;
        text-align: center;
        
        }
        .container #image {
            width: 100%;
            height: 100%;
            background-size: cover;
            background-repeat: no-repeat;
            background-position: 50% 50%;
        }
        #shadow {
            width: 100%;
            height: 25%;
            position: relative;
            left: 0px;
            vertical-align: bottom;
            top: calc(-100%/4);
            background-color: black;
            opacity: 0.5;
            
            
        }
        #title {
            width: 100%;
            height: 100%;
            color: white;
            text-align: center;
            font-weight: bold;
            font-size: calc(var(--base-unit)/4);
            position: relative;
            top: calc(-100%/2.18);
 
        }
    `;
    card.appendChild(content);
    card.appendChild(style);
    card.addEventListener('click', event => {
      this._fire('hass-more-info', { entityId: cardConfig.entity });
    });
    root.appendChild(card);
    this._config = cardConfig;
  }
  _fire(type, detail, options) {
    const node = this.shadowRoot;
    options = options || {};
    detail = (detail === null || detail === undefined) ? {} : detail;
    const event = new Event(type, {
      bubbles: options.bubbles === undefined ? true : options.bubbles,
      cancelable: Boolean(options.cancelable),
      composed: options.composed === undefined ? true : options.composed
    });
    event.detail = detail;
    node.dispatchEvent(event);
    return event;
  }
  
  set hass(hass) {
    const config = this._config;
    const entityState = hass.states[config.entity].state;

    const root = this.shadowRoot;
 
    var imgUrl = `url(${config.image})`;
    if (entityState !== this._entityState) {
        console.log(config.state_image);
        for (var key in config.state_image) {
            if (config.state_image.hasOwnProperty(key)) {           
                if (key == entityState)
                    imgUrl = `url(${config.state_image[key]})`;
            }
        }
        root.getElementById("title").textContent = entityState;
        
    }
    root.getElementById("image").style.backgroundImage = imgUrl;
    root.lastChild.hass = hass; 
  }
  getCardSize() {
    return 1;
  }
}

customElements.define('picture-entity-status', PictureEntityStatus);