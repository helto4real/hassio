import {html} from 'https://unpkg.com/@polymer/polymer/lib/utils/html-tag.js';

const HuiPictureEntityCard  = customElements.get('hui-picture-entity-card');
//const html = customElements.get('html');
class PictureEntityStatus extends HuiPictureEntityCard {
  static get template() {
    return html`
      <style>
        ha-card {
          min-height: 75px;
          overflow: hidden;
          position: relative;
        }
        ha-card.canInteract {
          cursor: pointer;
        }
        .info {
          @apply --paper-font-common-nowrap;
          position: absolute;
          left: 0;
          right: 0;
          bottom: 0;
          background-color: rgba(0, 0, 0, 0.3);
          padding: 16px;
          font-size: 16px;
          line-height: 16px;
          color: white;
          display: flex;
          justify-content: space-between;
        }
        #title {
          font-weight: 500;
        }
        [hidden] {
          display: none;
        }
      </style>
      <ha-card id='card' on-click="_cardClicked">
        <hui-image
          hass="[[hass]]"
          image="[[_config.image]]"
          state-image="[[_config.state_image]]"
          camera-image="[[_getCameraImage(_config)]]" 
          entity="[[_config.entity]]"
        ></hui-image>
        <div class="info" hidden$='[[_computeHideInfo(_config)]]'>
          <div id="kalle" style="font-size: 35px;">&nbsp;</div>
          <div id="state"></div>
          <div id="name"></div>
          <div id="bertil" style="font-size: 5px;" >&nbsp;</div>
          </div>
      </ha-card>
    `; // 
  }
  setConfig(config) {
    super.setConfig(config)
  }
 
}

customElements.define('picture-entity-status', PictureEntityStatus);
