const LitElement = customElements.get('home-assistant-main')
? Object.getPrototypeOf(customElements.get('home-assistant-main'))
: Object.getPrototypeOf(customElements.get('hui-view'));
const html = LitElement.prototype.html;
const css = LitElement.prototype.css;

  
class KrisinfoCard extends LitElement {
  
  setConfig(config) {

    if (!config.entity) {
      throw new Error('Please define entity');
    }
    this.config = config;
  }
  
  render(){
    if (!this.entity)
      return html`
      <hui-warning>
        ${this._hass.localize("ui.panel.lovelace.warning.entity_not_found",
          "entity",
          this.config.entity
        )}
      </hui-warning>
      `
    return html
    `
      ${this.config.only_alerts == false || this.config.only_alerts == null
        ? html
        `<ha-card>
          <div class="card-header">
            <div class="name">
              ${this.header}
            </div>
          </div>
          <div class="card-content">
          ${this.messages.length == 0
            ? html`<p>Inga meddelanden just nu</p>`
            : this.messages.map(message => 
              html`<div class="message">
                      <span>${message.SenderName}</span>
                        </br><span>Skickat: ${message.Published}</span>
                        <h3>${message.Event == "Alert" ? html`<ha-icon id="state-icon" icon="mdi:alert"></ha-icon>` : ''}${message.Headline}</h3>
                      <p class="">${message.Message}</p>
                      <a target="_blank" href="${message.Web}">Läs mer</a>
                    </div>
              `)}
              </div>
          </ha-card>`
        : // if only alerts
        html
        `
        ${this.state == "Alert" ?
          html
          `
            <ha-card>
              <div class="card-header">
                <div class="name">
                  ${this.state} - ${this.header}
                </div>
              </div>
              <div class="card-content">
              ${this.messages.length == 0
                ? html`<p>Inga meddelanden just nu</p>`
                : this.messages.map(message => 
                  html`
                  ${message.Event == "Alert" ?
                    html`<div class="message">
                            <span>${message.SenderName}</span>
                              </br><span>Skickat: ${message.Published}</span>
                              <h3>${message.Event == "Alert" ? html`<ha-icon id="state-icon" icon="mdi:alert"></ha-icon>` : ''}${message.Headline}</h3>
                            <p class="">${message.Message}</p>
                            <a target="_blank" href="${message.Web}">Läs mer</a>
                          </div>
                    `
                  : ''}`
                  )
              
                }</div>
            </ha-card>
          `
          : ''
        }
        `
      }
    `;
  }    

  static get styles() {
      return css
      `
          .header {
            padding: 0;
            @apply --paper-font-headline;
            line-height: 40px;
            color: var(--primary-text-color);
            padding: 4px 0 12px;
          }
          .message {
            padding-bottom: 1em;
          }
          h3 {
            margin-top: 10px;
            margin-bottom: 0;
          }
          p {
            margin-top: 7px;
          }
          .card {
            padding: 1em;
            padding-top: 0;
          }
          .state {
            display: block;
            margin: auto;
            text-align: center;
          }
          #state-icon {
            color: red;
            padding-right: 7px;
          }
      `;
    }
  
  set hass(hass) {
    this._hass = hass;
    this.entity = this.config.entity in hass.states ? hass.states[this.config.entity] : null;
    if(this.entity)
    {
      this.header = this.entity.attributes.friendly_name;
      this.messages = this.entity.attributes.messages;
      this.state = this.entity.state
    }

    this.requestUpdate();
  }



  // @TODO: This requires more intelligent logic
  getCardSize() {
    return 3;
  }
}

customElements.define('krisinfo-card', KrisinfoCard);
