!function(t){var e={};function i(n){if(e[n])return e[n].exports;var r=e[n]={i:n,l:!1,exports:{}};return t[n].call(r.exports,r,r.exports,i),r.l=!0,r.exports}i.m=t,i.c=e,i.d=function(t,e,n){i.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:n})},i.r=function(t){"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},i.t=function(t,e){if(1&e&&(t=i(t)),8&e)return t;if(4&e&&"object"==typeof t&&t&&t.__esModule)return t;var n=Object.create(null);if(i.r(n),Object.defineProperty(n,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var r in t)i.d(n,r,function(e){return t[e]}.bind(null,r));return n},i.n=function(t){var e=t&&t.__esModule?function(){return t.default}:function(){return t};return i.d(e,"a",e),e},i.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},i.p="",i(i.s=3)}([function(t,e,i){"use strict";i(1);
/**
@license
Copyright (c) 2017 The Polymer Project Authors. All rights reserved.
This code may only be used under the BSD style license found at http://polymer.github.io/LICENSE.txt
The complete set of authors may be found at http://polymer.github.io/AUTHORS.txt
The complete set of contributors may be found at http://polymer.github.io/CONTRIBUTORS.txt
Code distributed by Google as part of the polymer project is also
subject to an additional IP rights grant found at http://polymer.github.io/PATENTS.txt
*/let n=0;function r(){}r.prototype.__mixinApplications,r.prototype.__mixinSet;const s=function(t){let e=t.__mixinApplications;e||(e=new WeakMap,t.__mixinApplications=e);let i=n++;return function(n){let r=n.__mixinSet;if(r&&r[i])return n;let s=e,o=s.get(n);o||(o=t(n),s.set(n,o));let a=Object.create(o.__mixinSet||r||null);return a[i]=!0,o.__mixinSet=a,o}};
/**
@license
Copyright (c) 2017 The Polymer Project Authors. All rights reserved.
This code may only be used under the BSD style license found at http://polymer.github.io/LICENSE.txt
The complete set of authors may be found at http://polymer.github.io/AUTHORS.txt
The complete set of contributors may be found at http://polymer.github.io/CONTRIBUTORS.txt
Code distributed by Google as part of the polymer project is also
subject to an additional IP rights grant found at http://polymer.github.io/PATENTS.txt
*/let o=0,a=0,l=[],c=0,h=document.createTextNode("");new window.MutationObserver(function(){const t=l.length;for(let e=0;e<t;e++){let t=l[e];if(t)try{t()}catch(t){setTimeout(()=>{throw t})}}l.splice(0,t),a+=t}).observe(h,{characterData:!0});const d={run:t=>(h.textContent=c++,l.push(t),o++),cancel(t){const e=t-a;if(e>=0){if(!l[e])throw new Error("invalid async handle: "+t);l[e]=null}}},u=s(t=>{return class extends t{static createProperties(t){const e=this.prototype;for(let i in t)i in e||e._createPropertyAccessor(i)}static attributeNameForProperty(t){return t.toLowerCase()}static typeForProperty(t){}_createPropertyAccessor(t,e){this._addPropertyToAttributeMap(t),this.hasOwnProperty("__dataHasAccessor")||(this.__dataHasAccessor=Object.assign({},this.__dataHasAccessor)),this.__dataHasAccessor[t]||(this.__dataHasAccessor[t]=!0,this._definePropertyAccessor(t,e))}_addPropertyToAttributeMap(t){if(this.hasOwnProperty("__dataAttributes")||(this.__dataAttributes=Object.assign({},this.__dataAttributes)),!this.__dataAttributes[t]){const e=this.constructor.attributeNameForProperty(t);this.__dataAttributes[e]=t}}_definePropertyAccessor(t,e){Object.defineProperty(this,t,{get(){return this._getProperty(t)},set:e?function(){}:function(e){this._setProperty(t,e)}})}constructor(){super(),this.__dataEnabled=!1,this.__dataReady=!1,this.__dataInvalid=!1,this.__data={},this.__dataPending=null,this.__dataOld=null,this.__dataInstanceProps=null,this.__serializing=!1,this._initializeProperties()}ready(){this.__dataReady=!0,this._flushProperties()}_initializeProperties(){for(let t in this.__dataHasAccessor)this.hasOwnProperty(t)&&(this.__dataInstanceProps=this.__dataInstanceProps||{},this.__dataInstanceProps[t]=this[t],delete this[t])}_initializeInstanceProperties(t){Object.assign(this,t)}_setProperty(t,e){this._setPendingProperty(t,e)&&this._invalidateProperties()}_getProperty(t){return this.__data[t]}_setPendingProperty(t,e,i){let n=this.__data[t],r=this._shouldPropertyChange(t,e,n);return r&&(this.__dataPending||(this.__dataPending={},this.__dataOld={}),!this.__dataOld||t in this.__dataOld||(this.__dataOld[t]=n),this.__data[t]=e,this.__dataPending[t]=e),r}_invalidateProperties(){!this.__dataInvalid&&this.__dataReady&&(this.__dataInvalid=!0,d.run(()=>{this.__dataInvalid&&(this.__dataInvalid=!1,this._flushProperties())}))}_enableProperties(){this.__dataEnabled||(this.__dataEnabled=!0,this.__dataInstanceProps&&(this._initializeInstanceProperties(this.__dataInstanceProps),this.__dataInstanceProps=null),this.ready())}_flushProperties(){const t=this.__data,e=this.__dataPending,i=this.__dataOld;this._shouldPropertiesChange(t,e,i)&&(this.__dataPending=null,this.__dataOld=null,this._propertiesChanged(t,e,i))}_shouldPropertiesChange(t,e,i){return Boolean(e)}_propertiesChanged(t,e,i){}_shouldPropertyChange(t,e,i){return i!==e&&(i==i||e==e)}attributeChangedCallback(t,e,i,n){e!==i&&this._attributeToProperty(t,i),super.attributeChangedCallback&&super.attributeChangedCallback(t,e,i,n)}_attributeToProperty(t,e,i){if(!this.__serializing){const n=this.__dataAttributes,r=n&&n[t]||t;this[r]=this._deserializeValue(e,i||this.constructor.typeForProperty(r))}}_propertyToAttribute(t,e,i){this.__serializing=!0,i=arguments.length<3?this[t]:i,this._valueToNodeAttribute(this,i,e||this.constructor.attributeNameForProperty(t)),this.__serializing=!1}_valueToNodeAttribute(t,e,i){const n=this._serializeValue(e);void 0===n?t.removeAttribute(i):t.setAttribute(i,n)}_serializeValue(t){switch(typeof t){case"boolean":return t?"":void 0;default:return null!=t?t.toString():void 0}}_deserializeValue(t,e){switch(e){case Boolean:return null!==t;case Number:return Number(t);default:return t}}}});const _=s(t=>{const e=u(t);function i(t){const e=Object.getPrototypeOf(t);return e.prototype instanceof r?e:null}function n(t){if(!t.hasOwnProperty(JSCompiler_renameProperty("__ownProperties",t))){let e=null;t.hasOwnProperty(JSCompiler_renameProperty("properties",t))&&t.properties&&(e=
/**
@license
Copyright (c) 2017 The Polymer Project Authors. All rights reserved.
This code may only be used under the BSD style license found at http://polymer.github.io/LICENSE.txt
The complete set of authors may be found at http://polymer.github.io/AUTHORS.txt
The complete set of contributors may be found at http://polymer.github.io/CONTRIBUTORS.txt
Code distributed by Google as part of the polymer project is also
subject to an additional IP rights grant found at http://polymer.github.io/PATENTS.txt
*/
function(t){const e={};for(let i in t){const n=t[i];e[i]="function"==typeof n?{type:n}:n}return e}(t.properties)),t.__ownProperties=e}return t.__ownProperties}class r extends e{static get observedAttributes(){const t=this._properties;return t?Object.keys(t).map(t=>this.attributeNameForProperty(t)):[]}static finalize(){if(!this.hasOwnProperty(JSCompiler_renameProperty("__finalized",this))){const t=i(this);t&&t.finalize(),this.__finalized=!0,this._finalizeClass()}}static _finalizeClass(){const t=n(this);t&&this.createProperties(t)}static get _properties(){if(!this.hasOwnProperty(JSCompiler_renameProperty("__properties",this))){const t=i(this);this.__properties=Object.assign({},t&&t._properties,n(this))}return this.__properties}static typeForProperty(t){const e=this._properties[t];return e&&e.type}_initializeProperties(){this.constructor.finalize(),super._initializeProperties()}connectedCallback(){super.connectedCallback&&super.connectedCallback(),this._enableProperties()}disconnectedCallback(){super.disconnectedCallback&&super.disconnectedCallback()}}return r});
/**
@license
Copyright (c) 2017 The Polymer Project Authors. All rights reserved.
This code may only be used under the BSD style license found at http://polymer.github.io/LICENSE.txt
The complete set of authors may be found at http://polymer.github.io/AUTHORS.txt
The complete set of contributors may be found at http://polymer.github.io/CONTRIBUTORS.txt
Code distributed by Google as part of the polymer project is also
subject to an additional IP rights grant found at http://polymer.github.io/PATENTS.txt
*/
/**
 * @license
 * Copyright (c) 2017 The Polymer Project Authors. All rights reserved.
 * This code may only be used under the BSD style license found at
 * http://polymer.github.io/LICENSE.txt
 * The complete set of authors may be found at
 * http://polymer.github.io/AUTHORS.txt
 * The complete set of contributors may be found at
 * http://polymer.github.io/CONTRIBUTORS.txt
 * Code distributed by Google as part of the polymer project is also
 * subject to an additional IP rights grant found at
 * http://polymer.github.io/PATENTS.txt
 */
const p=new Map;class f{constructor(t,e,i,n=E){this.strings=t,this.values=e,this.type=i,this.partCallback=n}getHTML(){const t=this.strings.length-1;let e="",i=!0;for(let n=0;n<t;n++){const t=this.strings[n];e+=t;const r=b(t);e+=(i=r>-1?r<t.length:i)?g:m}return e+=this.strings[t]}getTemplateElement(){const t=document.createElement("template");return t.innerHTML=this.getHTML(),t}}const m=`{{lit-${String(Math.random()).slice(2)}}}`,g=`\x3c!--${m}--\x3e`,y=new RegExp(`${m}|${g}`),v=/[ \x09\x0a\x0c\x0d]([^\0-\x1F\x7F-\x9F \x09\x0a\x0c\x0d"'>=/]+)[ \x09\x0a\x0c\x0d]*=[ \x09\x0a\x0c\x0d]*(?:[^ \x09\x0a\x0c\x0d"'`<>=]*|"[^"]*|'[^']*)$/;function b(t){const e=t.lastIndexOf(">");return t.indexOf("<",e+1)>-1?t.length:e}class w{constructor(t,e,i,n,r){this.type=t,this.index=e,this.name=i,this.rawName=n,this.strings=r}}const x=t=>-1!==t.index;class P{constructor(t,e){this.parts=[],this.element=e;const i=this.element.content,n=document.createTreeWalker(i,133,null,!1);let r=-1,s=0;const o=[];let a,l;for(;n.nextNode();){r++,a=l;const e=l=n.currentNode;if(1===e.nodeType){if(!e.hasAttributes())continue;const i=e.attributes;let n=0;for(let t=0;t<i.length;t++)i[t].value.indexOf(m)>=0&&n++;for(;n-- >0;){const n=t.strings[s],o=v.exec(n)[1],a=i.getNamedItem(o),l=a.value.split(y);this.parts.push(new w("attribute",r,a.name,o,l)),e.removeAttribute(a.name),s+=l.length-1}}else if(3===e.nodeType){const t=e.nodeValue;if(t.indexOf(m)<0)continue;const i=e.parentNode,n=t.split(y),a=n.length-1;s+=a;for(let t=0;t<a;t++)i.insertBefore(""===n[t]?document.createComment(""):document.createTextNode(n[t]),e),this.parts.push(new w("node",r++));i.insertBefore(""===n[a]?document.createComment(""):document.createTextNode(n[a]),e),o.push(e)}else if(8===e.nodeType&&e.nodeValue===m){const t=e.parentNode,i=e.previousSibling;null===i||i!==a||i.nodeType!==Node.TEXT_NODE?t.insertBefore(document.createComment(""),e):r--,this.parts.push(new w("node",r++)),o.push(e),null===e.nextSibling?t.insertBefore(document.createComment(""),e):r--,l=a,s++}}for(const t of o)t.parentNode.removeChild(t)}}const C=(t,e)=>S(e)?(e=e(t),N):null===e?void 0:e,S=t=>"function"==typeof t&&!0===t.__litDirective,N={},T=t=>null===t||!("object"==typeof t||"function"==typeof t);class k{constructor(t,e,i,n){this.instance=t,this.element=e,this.name=i,this.strings=n,this.size=n.length-1,this._previousValues=[]}_interpolate(t,e){const i=this.strings,n=i.length-1;let r="";for(let s=0;s<n;s++){r+=i[s];const n=C(this,t[e+s]);if(n&&n!==N&&(Array.isArray(n)||"string"!=typeof n&&n[Symbol.iterator]))for(const t of n)r+=t;else r+=n}return r+i[n]}_equalToPreviousValues(t,e){for(let i=e;i<e+this.size;i++)if(this._previousValues[i]!==t[i]||!T(t[i]))return!1;return!0}setValue(t,e){if(this._equalToPreviousValues(t,e))return;const i=this.strings;let n;2===i.length&&""===i[0]&&""===i[1]?(n=C(this,t[e]),Array.isArray(n)&&(n=n.join(""))):n=this._interpolate(t,e),n!==N&&this.element.setAttribute(this.name,n),this._previousValues=t}}class O{constructor(t,e,i){this.instance=t,this.startNode=e,this.endNode=i,this._previousValue=void 0}setValue(t){if((t=C(this,t))!==N)if(T(t)){if(t===this._previousValue)return;this._setText(t)}else t instanceof f?this._setTemplateResult(t):Array.isArray(t)||t[Symbol.iterator]?this._setIterable(t):t instanceof Node?this._setNode(t):void 0!==t.then?this._setPromise(t):this._setText(t)}_insert(t){this.endNode.parentNode.insertBefore(t,this.endNode)}_setNode(t){this._previousValue!==t&&(this.clear(),this._insert(t),this._previousValue=t)}_setText(t){const e=this.startNode.nextSibling;t=void 0===t?"":t,e===this.endNode.previousSibling&&e.nodeType===Node.TEXT_NODE?e.textContent=t:this._setNode(document.createTextNode(t)),this._previousValue=t}_setTemplateResult(t){const e=this.instance._getTemplate(t);let i;this._previousValue&&this._previousValue.template===e?i=this._previousValue:(i=new A(e,this.instance._partCallback,this.instance._getTemplate),this._setNode(i._clone()),this._previousValue=i),i.update(t.values)}_setIterable(t){Array.isArray(this._previousValue)||(this.clear(),this._previousValue=[]);const e=this._previousValue;let i=0;for(const n of t){let t=e[i];if(void 0===t){let n=this.startNode;if(i>0){n=e[i-1].endNode=document.createTextNode(""),this._insert(n)}t=new O(this.instance,n,this.endNode),e.push(t)}t.setValue(n),i++}if(0===i)this.clear(),this._previousValue=void 0;else if(i<e.length){const t=e[i-1];e.length=i,this.clear(t.endNode.previousSibling),t.endNode=this.endNode}}_setPromise(t){this._previousValue=t,t.then(e=>{this._previousValue===t&&this.setValue(e)})}clear(t=this.startNode){z(this.startNode.parentNode,t.nextSibling,this.endNode)}}const E=(t,e,i)=>{if("attribute"===e.type)return new k(t,i,e.name,e.strings);if("node"===e.type)return new O(t,i,i.nextSibling);throw new Error(`Unknown part type ${e.type}`)};class A{constructor(t,e,i){this._parts=[],this.template=t,this._partCallback=e,this._getTemplate=i}update(t){let e=0;for(const i of this._parts)i?void 0===i.size?(i.setValue(t[e]),e++):(i.setValue(t,e),e+=i.size):e++}_clone(){const t=this.template.element.content.cloneNode(!0),e=this.template.parts;if(e.length>0){const i=document.createTreeWalker(t,133,null,!1);let n=-1;for(let t=0;t<e.length;t++){const r=e[t],s=x(r);if(s)for(;n<r.index;)n++,i.nextNode();this._parts.push(s?this._partCallback(this,r,i.currentNode):void 0)}}return t}}const z=(t,e,i=null)=>{let n=e;for(;n!==i;){const e=n.nextSibling;t.removeChild(n),n=e}},V=NodeFilter.SHOW_ELEMENT|NodeFilter.SHOW_COMMENT|NodeFilter.SHOW_TEXT;const I=t=>{let e=1;const i=document.createTreeWalker(t,V,null,!1);for(;i.nextNode();)e++;return e},R=(t,e=-1)=>{for(let i=e+1;i<t.length;i++){const e=t[i];if(x(e))return i}return-1};
/**
 * @license
 * Copyright (c) 2017 The Polymer Project Authors. All rights reserved.
 * This code may only be used under the BSD style license found at
 * http://polymer.github.io/LICENSE.txt
 * The complete set of authors may be found at
 * http://polymer.github.io/AUTHORS.txt
 * The complete set of contributors may be found at
 * http://polymer.github.io/CONTRIBUTORS.txt
 * Code distributed by Google as part of the polymer project is also
 * subject to an additional IP rights grant found at
 * http://polymer.github.io/PATENTS.txt
 */
const j=(t,e)=>`${t}--${e}`,$=t=>e=>{const i=j(e.type,t);let n=p.get(i);void 0===n&&(n=new Map,p.set(i,n));let r=n.get(e.strings);if(void 0===r){const i=e.getTemplateElement();"object"==typeof window.ShadyCSS&&window.ShadyCSS.prepareTemplateDom(i,t),r=new P(e,i),n.set(e.strings,r)}return r},H=["html","svg"];function M(t){H.forEach(e=>{const i=p.get(j(e,t));void 0!==i&&i.forEach(t=>{const{element:{content:e}}=t,i=e.querySelectorAll("style");!function(t,e){const{element:{content:i},parts:n}=t,r=document.createTreeWalker(i,V,null,!1);let s=0,o=n[0],a=-1,l=0;const c=[];let h=null;for(;r.nextNode();){a++;const t=r.currentNode;for(t.previousSibling===h&&(h=null),e.has(t)&&(c.push(t),null===h&&(h=t)),null!==h&&l++;void 0!==o&&o.index===a;)o.index=null!==h?-1:o.index-l,o=n[++s]}c.forEach(t=>t.parentNode.removeChild(t))}(t,new Set(Array.from(i)))})})}const q=new Set,L=(t,e,i)=>{if(!q.has(i)){q.add(i);const n=document.createElement("template");if(Array.from(t.querySelectorAll("style")).forEach(t=>{n.content.appendChild(t)}),window.ShadyCSS.prepareTemplateStyles(n,i),M(i),window.ShadyCSS.nativeShadow){const i=n.content.querySelector("style");null!==i&&(t.insertBefore(i,t.firstChild),function(t,e,i=null){const{element:{content:n},parts:r}=t;if(null===i||void 0===i)return void n.appendChild(e);const s=document.createTreeWalker(n,V,null,!1);let o=R(r),a=0,l=-1;for(;s.nextNode();)for(l++,s.currentNode===i&&(i.parentNode.insertBefore(e,i),a=I(e));-1!==o&&r[o].index===l;){if(a>0){for(;-1!==o;)r[o].index+=a,o=R(r,o);return}o=R(r,o)}}(e,i.cloneNode(!0),e.element.content.firstChild))}}};
/**
 * @license
 * Copyright (c) 2017 The Polymer Project Authors. All rights reserved.
 * This code may only be used under the BSD style license found at
 * http://polymer.github.io/LICENSE.txt
 * The complete set of authors may be found at
 * http://polymer.github.io/AUTHORS.txt
 * The complete set of contributors may be found at
 * http://polymer.github.io/CONTRIBUTORS.txt
 * Code distributed by Google as part of the polymer project is also
 * subject to an additional IP rights grant found at
 * http://polymer.github.io/PATENTS.txt
 */
const F=(t,...e)=>new f(t,e,"html",B),B=(t,e,i)=>{if("attribute"===e.type){if("on-"===e.rawName.substr(0,3)){return new class{constructor(t,e,i){this.instance=t,this.element=e,this.eventName=i}setValue(t){const e=C(this,t);e!==this._listener&&(null==e?this.element.removeEventListener(this.eventName,this):null==this._listener&&this.element.addEventListener(this.eventName,this),this._listener=e)}handleEvent(t){"function"==typeof this._listener?this._listener.call(this.element,t):"function"==typeof this._listener.handleEvent&&this._listener.handleEvent(t)}}(t,i,e.rawName.slice(3))}const n=e.name.substr(e.name.length-1);if("$"===n){const n=e.name.slice(0,-1);return new k(t,i,n,e.strings)}if("?"===n){return new class extends k{setValue(t,e){const i=this.strings;if(2!==i.length||""!==i[0]||""!==i[1])throw new Error("boolean attributes can only contain a single expression");{const i=C(this,t[e]);if(i===N)return;i?this.element.setAttribute(this.name,""):this.element.removeAttribute(this.name)}}}(t,i,e.name.slice(0,-1),e.strings)}return new class extends k{setValue(t,e){const i=this.strings;let n;this._equalToPreviousValues(t,e)||((n=2===i.length&&""===i[0]&&""===i[1]?C(this,t[e]):this._interpolate(t,e))!==N&&(this.element[this.name]=n),this._previousValues=t)}}(t,i,e.rawName,e.strings)}return E(t,e,i)};i.d(e,"a",function(){return W}),i.d(e,"b",function(){return F}),i.d(e,!1,function(){});class W extends(_(HTMLElement)){constructor(){super(...arguments),this.__renderComplete=null,this.__resolveRenderComplete=null,this.__isInvalid=!1,this.__isChanging=!1}ready(){this._root=this._createRoot(),super.ready(),this._firstRendered()}connectedCallback(){window.ShadyCSS&&this._root&&window.ShadyCSS.styleElement(this),super.connectedCallback()}_firstRendered(){}_createRoot(){return this.attachShadow({mode:"open"})}_shouldPropertiesChange(t,e,i){const n=this._shouldRender(t,e,i);return!n&&this.__resolveRenderComplete&&this.__resolveRenderComplete(!1),n}_shouldRender(t,e,i){return!0}_propertiesChanged(t,e,i){super._propertiesChanged(t,e,i);const n=this._render(t);n&&void 0!==this._root&&this._applyRender(n,this._root),this._didRender(t,e,i),this.__resolveRenderComplete&&this.__resolveRenderComplete(!0)}_flushProperties(){this.__isChanging=!0,this.__isInvalid=!1,super._flushProperties(),this.__isChanging=!1}_shouldPropertyChange(t,e,i){const n=super._shouldPropertyChange(t,e,i);return n&&this.__isChanging&&console.trace("Setting properties in response to other properties changing "+`considered harmful. Setting '${t}' from `+`'${this._getProperty(t)}' to '${e}'.`),n}_render(t){throw new Error("_render() not implemented")}_applyRender(t,e){!function(t,e,i){const n=$(i),r=n(t);let s=e.__templateInstance;if(void 0!==s&&s.template===r&&s._partCallback===t.partCallback)return void s.update(t.values);s=new A(r,t.partCallback,n),e.__templateInstance=s;const o=s._clone();s.update(t.values);const a=e instanceof ShadowRoot?e.host:void 0;void 0!==a&&"object"==typeof window.ShadyCSS&&(L(o,r,i),window.ShadyCSS.styleElement(a)),z(e,e.firstChild),e.appendChild(o)}(t,e,this.localName)}_didRender(t,e,i){}requestRender(){this._invalidateProperties()}_invalidateProperties(){this.__isInvalid=!0,super._invalidateProperties()}get renderComplete(){return this.__renderComplete||(this.__renderComplete=new Promise(t=>{this.__resolveRenderComplete=(e=>{this.__resolveRenderComplete=this.__renderComplete=null,t(e)})}),!this.__isInvalid&&this.__resolveRenderComplete&&Promise.resolve().then(()=>this.__resolveRenderComplete(!1))),this.__renderComplete}}},function(t,e){
/**
@license
Copyright (c) 2017 The Polymer Project Authors. All rights reserved.
This code may only be used under the BSD style license found at http://polymer.github.io/LICENSE.txt
The complete set of authors may be found at http://polymer.github.io/AUTHORS.txt
The complete set of contributors may be found at http://polymer.github.io/CONTRIBUTORS.txt
Code distributed by Google as part of the polymer project is also
subject to an additional IP rights grant found at http://polymer.github.io/PATENTS.txt
*/
window.JSCompiler_renameProperty=function(t){return t}},function(t,e){var i,n,r=t.exports={};function s(){throw new Error("setTimeout has not been defined")}function o(){throw new Error("clearTimeout has not been defined")}function a(t){if(i===setTimeout)return setTimeout(t,0);if((i===s||!i)&&setTimeout)return i=setTimeout,setTimeout(t,0);try{return i(t,0)}catch(e){try{return i.call(null,t,0)}catch(e){return i.call(this,t,0)}}}!function(){try{i="function"==typeof setTimeout?setTimeout:s}catch(t){i=s}try{n="function"==typeof clearTimeout?clearTimeout:o}catch(t){n=o}}();var l,c=[],h=!1,d=-1;function u(){h&&l&&(h=!1,l.length?c=l.concat(c):d=-1,c.length&&_())}function _(){if(!h){var t=a(u);h=!0;for(var e=c.length;e;){for(l=c,c=[];++d<e;)l&&l[d].run();d=-1,e=c.length}l=null,h=!1,function(t){if(n===clearTimeout)return clearTimeout(t);if((n===o||!n)&&clearTimeout)return n=clearTimeout,clearTimeout(t);try{n(t)}catch(e){try{return n.call(null,t)}catch(e){return n.call(this,t)}}}(t)}}function p(t,e){this.fun=t,this.array=e}function f(){}r.nextTick=function(t){var e=new Array(arguments.length-1);if(arguments.length>1)for(var i=1;i<arguments.length;i++)e[i-1]=arguments[i];c.push(new p(t,e)),1!==c.length||h||a(_)},p.prototype.run=function(){this.fun.apply(null,this.array)},r.title="browser",r.browser=!0,r.env={},r.argv=[],r.version="",r.versions={},r.on=f,r.addListener=f,r.once=f,r.off=f,r.removeListener=f,r.removeAllListeners=f,r.emit=f,r.prependListener=f,r.prependOnceListener=f,r.listeners=function(t){return[]},r.binding=function(t){throw new Error("process.binding is not supported")},r.cwd=function(){return"/"},r.chdir=function(t){throw new Error("process.chdir is not supported")},r.umask=function(){return 0}},function(t,e,i){"use strict";i.r(e);i(4),i(5)},function(t,e,i){"use strict";(function(t){var e=i(0);
/*!
 * The MIT License (MIT)
 *
 * Copyright (c) 2017 Tomas Hellström  (https://github.com/helto4real/lovelace-custom-cards)
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */window.customElements.define("picture-status-card",class extends e.a{_render({hass:t,config:i}){return e["b"]`
        
        <style>
            #container {
                max-width: 100%;
                height: 100px;        
                position: relative;
                top: 0px;
                overflow: hidden;
                text-align: center;
                background-size: cover;
                background-repeat: no-repeat;
                background-position: 50% 50%;
            }
            .shadow {
              width: 100%;
              height: 25%;
              left: 0px;
              bottom: 0;
              background: rgba(0, 0, 0, 0.4);;
              position: absolute;
            }
            #state{
              position: relative;
              float: left;
              top: 50%;
              left: 50%;
              color: white;
              font-size: 100%;
              transform: translate(-50%, -50%);
            }
        </style>
        <div id="container" on-click="${()=>this._click()}">
          <div class="shadow"><div id="state">${this.state}</div></div>
        </div>
        
        `}_didRender(t,e,i){const n=this._root.querySelector("#container"),r=this._root.querySelector("#state");n.style.backgroundImage=`url(${this._getStateImage()})`,n.style.height=this._card_height,this._font_size=this._config.font_size?this._config.font_size:`calc(${this._card_height}/6)`,r.style.fontSize=this._font_size,r.style.color=this._font_color}_click(){this._fire("hass-more-info",{entityId:this._config.entity})}_fire(t,e){const i=new Event(t,{bubbles:!0,cancelable:!1,composed:!0});return i.detail=e||{},this._root.dispatchEvent(i),i}_getStateImage(){return this.state in this._config.state_image?this._config.state_image[this.state]:this._config.image}setConfig(t){if(this._config=t,!t.entity)throw Error("No entity defined");if(!t.image)throw Error("No image defined");this._card_height=t.card_height?t.card_height:"200px",this._font_color=t.font_color?t.font_color:"white"}set hass(t){if(t){this._hass=t;var e=this._hass.states[this._config.entity].state;e!=this.state&&(this.state=e)}}static get properties(){return{hass:Object,config:Object,state:String}}getCardSize(){return 2}constructor(){super(),void 0===t&&this.__initTests()}__initTests(){this.state="Home";var t={entity:"device_tracker.any",image:"test/img/tomas_presence_away.jpg",state_image:{}};t.state_image.Home="test/img/tomas_presence_away.jpg",[][t.entity]="Home",this.setConfig(t)}})}).call(this,i(2))},function(t,e,i){"use strict";(function(t){var e=i(0);
/*!
 * The MIT License (MIT)
 *
 * Copyright (c) 2017 Tomas Hellström  (https://github.com/helto4real/lovelace-custom-cards)
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */window.customElements.define("media-player-card",class extends e.a{_render({hass:t,config:i}){return e["b"]`
        <style>
            #card {
              width: 88%;
              height: 100%;
              margin: auto;
            }
            #container {
                width: calc(561px/1.3);
                height: calc(406px/1.3);;
                position: relative;
                top: 0px;
                overflow: hidden;
                text-align: center;
                background-size: cover;
                background-repeat: no-repeat;
                background-position: 50% 50%;
                transform: none;
            }

            #movie-image {
                position: relative;
                width: 93.6%;
                height: 72%;
                left: 3.2%;
                top: 4.4%;
                background-size: cover;
                background-repeat: no-repeat;
                background-color: darkgray;
                transform: none;
            }

            #media-info {
                width: 99.95%;
                height: 30%;
                left:0;
                top: 70%;
                background: rgba(0, 0, 0, 0.5);
                position: absolute;
                transform: none;
            }

            #entity {
                position: relative;
                width: 100%;
                top: 8%;
                left: 2.3%;
                color: white;
                text-align: left;
                font-size: 85%;
                transform: none;
            }

            #media-title {
                position: relative;
                width: 100%;
                top: 18%;
                left: 2.3%;
                text-align: left;
                color: white;
                font-weight: bold;
                font-size: 100%;
                transform: none;
            }

            #app-name {
                position: relative;
                width: 100%;
                text-align: left;
                top: 12%;
                left: 2.3%;
                color: white;
                font-size: 85%;
                transform: none;
            }
        </style>
        <div id="card">
          <div id="container" on-click="${()=>this._click()}">
              <div id="movie-image">
                  <div id="media-info">
                      <div id="entity"></div>
                      <div id="media-title"></div>
                      <div id="app-name">HBO Nordic</div>
                  </div>
              </div>
          </div>
        </div>
        
        `}_didRender(t,e,i){const n=this._root.querySelector("#container"),r=this._root.querySelector("#movie-image"),s=this._root.querySelector("#entity"),o=this._root.querySelector("#media-title"),a=this._root.querySelector("#app-name");n.style.backgroundImage=`url(${this._config.image_folder}/tv.png)`;const l=this._hass.states[this._config.entity],c=l.attributes;c.entity_picture?r.style.backgroundImage=`url(${c.entity_picture})`:c.app_name&&-1!==c.app_name.toLowerCase().indexOf("netflix")&&(r.style.backgroundImage=`url(${this._config.image_folder}/netflix-logo.png)`),s.innerText=c.friendly_name?c.friendly_name:this._config.entity,o.innerText=c.media_title?c.media_title:l.state,a.innerText=c.app_name?c.app_name:"Nothing is currently playing"}_click(){this._fire("hass-more-info",{entityId:this._config.entity})}_fire(t,e){const i=new Event(t,{bubbles:!0,cancelable:!1,composed:!0});return i.detail=e||{},this._root.dispatchEvent(i),i}setConfig(t){if(this._config=t,!t.entity)throw Error("No entity defined");if(!t.image_folder)throw Error("No image_folder defined")}set hass(t){if(t){this._hass=t;var e=this._hass.states[this._config.entity].state;e!=this.state&&(this.state=e)}}static get properties(){return{hass:Object,config:Object,state:String}}getCardSize(){return 2}constructor(){super(),void 0===t&&this.__initTests()}__initTests(){this.state="idle";var t={entity:"media_player.tv_nere",image_folder:"img"};const e={states:{}};e.states[t.entity]={attributes:{},state:"playing"};const i=e.states[t.entity].attributes;i.friendly_name="TV Nere",i.app_name="HBO Nordic Netflix",i.media_title="Game of thrones",this.setConfig(t),this._hass=e}})}).call(this,i(2))}]);