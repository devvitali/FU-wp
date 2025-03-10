/*! normalize.css v8.0.1 | MIT License | github.com/necolas/normalize.css */
/* Document
   ========================================================================== */
/**
 * 1. Correct the line height in all browsers.
 * 2. Prevent adjustments of font size after orientation changes in iOS.
 */
html {
  line-height: 1.15; /* 1 */
  -webkit-text-size-adjust: 100%; /* 2 */
}

/* Sections
   ========================================================================== */
/**
 * Remove the margin in all browsers.
 */
body {
  margin: 0;
}

/**
 * Render the `main` element consistently in IE.
 */
main {
  display: block;
}

/**
 * Correct the font size and margin on `h1` elements within `section` and
 * `article` contexts in Chrome, Firefox, and Safari.
 */
h1 {
  font-size: 2em;
  margin: 0.67em 0;
}

/* Grouping content
   ========================================================================== */
/**
 * 1. Add the correct box sizing in Firefox.
 * 2. Show the overflow in Edge and IE.
 */
hr {
  box-sizing: content-box; /* 1 */
  height: 0; /* 1 */
  overflow: visible; /* 2 */
}

/**
 * 1. Correct the inheritance and scaling of font size in all browsers.
 * 2. Correct the odd `em` font sizing in all browsers.
 */
pre {
  font-family: monospace, monospace; /* 1 */
  font-size: 1em; /* 2 */
}

/* Text-level semantics
   ========================================================================== */
/**
 * Remove the gray background on active links in IE 10.
 */
a {
  background-color: transparent;
}

/**
 * 1. Remove the bottom border in Chrome 57-
 * 2. Add the correct text decoration in Chrome, Edge, IE, Opera, and Safari.
 */
abbr[title] {
  border-bottom: none; /* 1 */
  text-decoration: underline; /* 2 */
  text-decoration: underline dotted; /* 2 */
}

/**
 * Add the correct font weight in Chrome, Edge, and Safari.
 */
b,
strong {
  font-weight: bolder;
}

/**
 * 1. Correct the inheritance and scaling of font size in all browsers.
 * 2. Correct the odd `em` font sizing in all browsers.
 */
code,
kbd,
samp {
  font-family: monospace, monospace; /* 1 */
  font-size: 1em; /* 2 */
}

/**
 * Add the correct font size in all browsers.
 */
small {
  font-size: 80%;
}

/**
 * Prevent `sub` and `sup` elements from affecting the line height in
 * all browsers.
 */
sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/* Embedded content
   ========================================================================== */
/**
 * Remove the border on images inside links in IE 10.
 */
img {
  border-style: none;
}

/* Forms
   ========================================================================== */
/**
 * 1. Change the font styles in all browsers.
 * 2. Remove the margin in Firefox and Safari.
 */
button,
input,
optgroup,
select,
textarea {
  font-family: inherit; /* 1 */
  font-size: 100%; /* 1 */
  line-height: 1.15; /* 1 */
  margin: 0; /* 2 */
}

/**
 * Show the overflow in IE.
 * 1. Show the overflow in Edge.
 */
button,
input { /* 1 */
  overflow: visible;
}

/**
 * Remove the inheritance of text transform in Edge, Firefox, and IE.
 * 1. Remove the inheritance of text transform in Firefox.
 */
button,
select { /* 1 */
  text-transform: none;
}

/**
 * Correct the inability to style clickable types in iOS and Safari.
 */
button,
[type=button],
[type=reset],
[type=submit] {
  -webkit-appearance: button;
}

/**
 * Remove the inner border and padding in Firefox.
 */
button::-moz-focus-inner,
[type=button]::-moz-focus-inner,
[type=reset]::-moz-focus-inner,
[type=submit]::-moz-focus-inner {
  border-style: none;
  padding: 0;
}

/**
 * Restore the focus styles unset by the previous rule.
 */
button:-moz-focusring,
[type=button]:-moz-focusring,
[type=reset]:-moz-focusring,
[type=submit]:-moz-focusring {
  outline: 1px dotted ButtonText;
}

/**
 * Correct the padding in Firefox.
 */
fieldset {
  padding: 0.35em 0.75em 0.625em;
}

/**
 * 1. Correct the text wrapping in Edge and IE.
 * 2. Correct the color inheritance from `fieldset` elements in IE.
 * 3. Remove the padding so developers are not caught out when they zero out
 *    `fieldset` elements in all browsers.
 */
legend {
  box-sizing: border-box; /* 1 */
  color: inherit; /* 2 */
  display: table; /* 1 */
  max-width: 100%; /* 1 */
  padding: 0; /* 3 */
  white-space: normal; /* 1 */
}

/**
 * Add the correct vertical alignment in Chrome, Firefox, and Opera.
 */
progress {
  vertical-align: baseline;
}

/**
 * Remove the default vertical scrollbar in IE 10+.
 */
textarea {
  overflow: auto;
}

/**
 * 1. Add the correct box sizing in IE 10.
 * 2. Remove the padding in IE 10.
 */
[type=checkbox],
[type=radio] {
  box-sizing: border-box; /* 1 */
  padding: 0; /* 2 */
}

/**
 * Correct the cursor style of increment and decrement buttons in Chrome.
 */
[type=number]::-webkit-inner-spin-button,
[type=number]::-webkit-outer-spin-button {
  height: auto;
}

/**
 * 1. Correct the odd appearance in Chrome and Safari.
 * 2. Correct the outline style in Safari.
 */
[type=search] {
  -webkit-appearance: textfield; /* 1 */
  outline-offset: -2px; /* 2 */
}

/**
 * Remove the inner padding in Chrome and Safari on macOS.
 */
[type=search]::-webkit-search-decoration {
  -webkit-appearance: none;
}

/**
 * 1. Correct the inability to style clickable types in iOS and Safari.
 * 2. Change font properties to `inherit` in Safari.
 */
::-webkit-file-upload-button {
  -webkit-appearance: button; /* 1 */
  font: inherit; /* 2 */
}

/* Interactive
   ========================================================================== */
/*
 * Add the correct display in Edge, IE 10+, and Firefox.
 */
details {
  display: block;
}

/*
 * Add the correct display in all browsers.
 */
summary {
  display: list-item;
}

/* Misc
   ========================================================================== */
/**
 * Add the correct display in IE 10+.
 */
template {
  display: none;
}

/**
 * Add the correct display in IE 10.
 */
[hidden] {
  display: none;
}

ul {
  margin: 0;
  padding: 0;
}

li {
  text-decoration: none;
}

.video-content a, .reasons .reasons-wrapper .reasons-descr > a, .experience .experience-wrapper > a, .footer .footer-wrapper .footer-item > a.subscribe-link, header .sliding-panel-content > a.subscribe-link, header .popup .popup-body .popup-content .popup-box .popup-descr button {
  display: inline-block;
  font-family: "Satoshi-Regular", sans-serif;
  font-weight: 400;
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #FFFFFF;
  background: #149926;
  border: 1px solid #149926;
  border-radius: 90px;
  padding: 12px 47px;
  transition: background 0.5s ease, color 0.5s ease;
}
.video-content a:hover, .reasons .reasons-wrapper .reasons-descr > a:hover, .experience .experience-wrapper > a:hover, .footer .footer-wrapper .footer-item > a.subscribe-link:hover, header .sliding-panel-content > a.subscribe-link:hover, header .popup .popup-body .popup-content .popup-box .popup-descr button:hover {
  background: #FFFFFF;
  color: #149926;
}

.experience-anchors .anchors-wrapper .anchors-items .anchor-item > a {
  font-family: "Satoshi-Regular", sans-serif;
  font-weight: 400;
  font-size: 0.9375rem;
  line-height: 1.25rem;
  letter-spacing: 0.09em;
  text-align: center;
  color: #000000;
  background: #FFFFFF;
  border: 1px solid #000000;
  padding: 14px 15px 14px 47px;
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 10px;
  text-transform: uppercase;
  min-width: 331px;
  transition: background 0.5s ease, color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
}
.experience-anchors .anchors-wrapper .anchors-items .anchor-item > a:hover {
  background: #149926;
  border: 1px solid #149926;
  color: #FFFFFF;
}

@media (max-width: 767px) {
  .video-content a, .reasons .reasons-wrapper .reasons-descr > a, .experience .experience-wrapper > a, .footer .footer-wrapper .footer-item > a.subscribe-link, header .sliding-panel-content > a.subscribe-link, header .popup .popup-body .popup-content .popup-box .popup-descr button {
    font-size: 1.125rem;
    line-height: 1.5rem;
    padding: 11px 38px;
  }
  .experience-anchors .anchors-wrapper .anchors-items .anchor-item > a {
    font-size: 0.9375rem;
    line-height: 1.25rem;
    padding: 10px 15px 10px 40px;
    gap: 14px;
    min-width: auto;
  }
}
html {
  box-sizing: border-box;
  scroll-behavior: smooth;
  --scroll-behavior: smooth;
  font-size: 16px;
  width: 100%;
  height: 100%;
}

*,
*::after,
*::before {
  box-sizing: inherit;
}

a,
button {
  cursor: pointer;
  color: inherit;
  text-decoration: none;
}

ul,
li {
  list-style: none;
}

body {
  font-family: "Satoshi-Regular", sans-serif;
  font-weight: 400;
  color: #000000;
  background-color: #FFFFFF;
}
body :first-child {
  margin-top: 0 !important;
}
body :last-child {
  margin-bottom: 0 !important;
}

.wrapper {
  display: flex;
  flex-direction: column;
  height: 100%;
  position: relative;
  overflow-x: hidden;
}

main {
  flex: 1 1 auto;
  margin: 100px 0 0 0;
}

footer {
  flex: 0 0 auto;
}

.container {
  width: 1700px;
  max-width: 95%;
  margin: 0 auto;
  position: relative;
}

.container-fluid {
  width: 850px;
  max-width: 95%;
  margin: 0 auto;
  position: relative;
}

h1,
h2,
h3,
h4,
h5,
h6 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  margin: 0 0 30px 0;
  text-transform: lowercase;
}

h1 {
  font-size: 2.1875rem;
  line-height: 2.4375rem;
}

h2 {
  font-size: 1.875rem;
  line-height: 2.0625rem;
}

h3 {
  font-size: 1.6875rem;
  line-height: 1.9375rem;
}

h4 {
  font-size: 1.25rem;
  line-height: 1.375rem;
}

h5,
h6 {
  font-size: 1.125rem;
  line-height: 1.25rem;
}

p {
  font-size: 1.125rem;
  line-height: 1.5rem;
  margin: 0 0 20px 0;
}

.fu {
  text-indent: -9999px;
  background: url("../img/svg/logo-2.svg") no-repeat;
  width: 34px;
  height: 21px;
  background-size: cover;
  background-position: center;
  display: inline-block;
  margin: 0 5px;
}

@font-face {
  font-family: "Satoshi-Regular";
  src: url("../fonts/Satoshi-Regular.eot");
  src: local("Satoshi-Regular"), local("Satoshi-Regular"), url("../fonts/Satoshi-Regular.eot?#iefix") format("embedded-opentype"), url("../fonts/Satoshi-Regular.woff") format("woff"), url("../fonts/Satoshi-Regular.ttf") format("truetype");
  font-weight: 400;
  font-style: normal;
}
@font-face {
  font-family: "Satoshi-LightItalic";
  src: url("../fonts/Satoshi-LightItalic.eot");
  src: local("Satoshi-LightItalic"), local("Satoshi-LightItalic"), url("../fonts/Satoshi-LightItalic.eot?#iefix") format("embedded-opentype"), url("../fonts/Satoshi-LightItalic.woff") format("woff"), url("../fonts/Satoshi-LightItalic.ttf") format("truetype");
  font-weight: 300;
  font-style: italic;
}
@media (min-width: 1559px) and (max-width: 1919px) {
  main {
    margin: 76px 0 0 0;
  }
}
@media (min-width: 1080px) and (max-width: 1559px) {
  main {
    margin: 66px 0 0 0;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  body._lock {
    overflow: hidden;
  }
  main {
    margin: 59px 0 0 0;
  }
}
@media (max-width: 767px) {
  body._lock {
    overflow: hidden;
  }
  main {
    margin: 56px 0 0 0;
  }
  .container {
    max-width: 90%;
  }
  .container-fluid {
    max-width: 90%;
  }
  .fu {
    width: 29px;
    height: 18px;
  }
}
/* Slider */
.slick-slider {
  position: relative;
  display: block;
  box-sizing: border-box;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  -webkit-touch-callout: none;
  -khtml-user-select: none;
  -ms-touch-action: pan-y;
  touch-action: pan-y;
  -webkit-tap-highlight-color: transparent;
}

.slick-list {
  position: relative;
  display: block;
  overflow: hidden;
  margin: 0;
  padding: 0;
}

.slick-list:focus {
  outline: none;
}

.slick-list.dragging {
  cursor: pointer;
  cursor: hand;
}

.slick-slider .slick-track,
.slick-slider .slick-list {
  -webkit-transform: translate3d(0, 0, 0);
  -moz-transform: translate3d(0, 0, 0);
  -ms-transform: translate3d(0, 0, 0);
  -o-transform: translate3d(0, 0, 0);
  transform: translate3d(0, 0, 0);
}

.slick-track {
  position: relative;
  top: 0;
  left: 0;
  display: block;
  margin-left: auto;
  margin-right: auto;
}

.slick-track:before,
.slick-track:after {
  display: table;
  content: "";
}

.slick-track:after {
  clear: both;
}

.slick-loading .slick-track {
  visibility: hidden;
}

.slick-slide {
  display: none;
  float: left;
  height: 100%;
  min-height: 1px;
}

[dir=rtl] .slick-slide {
  float: right;
}

.slick-slide img {
  display: block;
}

.slick-slide.slick-loading img {
  display: none;
}

.slick-slide.dragging img {
  pointer-events: none;
}

.slick-initialized .slick-slide {
  display: block;
}

.slick-loading .slick-slide {
  visibility: hidden;
}

.slick-vertical .slick-slide {
  display: block;
  height: auto;
  border: 1px solid transparent;
}

.slick-arrow.slick-hidden {
  display: none;
}

header {
  position: fixed;
  width: 100%;
  top: 0;
  left: 0;
  right: 0;
  margin-left: auto;
  margin-right: auto;
  transition: all 0.9s ease;
  padding: 8px 0 25px 0;
  z-index: 2;
  background-color: #FFFFFF;
  box-shadow: 0 8px 4px -4px rgba(0, 0, 0, 0.2);
}
header .header-container {
  width: 1770px;
  max-width: 95%;
  margin: 0 auto;
}
header .header-container .header-wrapper {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 50%;
}
header .header-container .header-wrapper .burger-wrapper .burger-box {
  z-index: 1;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 60px;
  height: 60px;
  background-color: transparent;
  cursor: pointer;
  -webkit-transition: 0.3s;
  -o-transition: 0.3s;
  transition: 0.3s;
  margin-right: auto;
}
header .header-container .header-wrapper .burger-wrapper .burger-box > span {
  display: block;
  height: 2px;
  width: 100%;
  background: #000000;
  -webkit-transition: 0.3s;
  -o-transition: 0.3s;
  transition: 0.3s;
  z-index: 1;
}
header .header-container .header-wrapper .burger-wrapper .burger-box > span:nth-child(2) {
  width: 100%;
  margin-top: 12px;
}
header .header-container .header-wrapper .burger-wrapper .burger-box > span:nth-child(3) {
  width: 100%;
  margin-top: 12px;
}
header .header-container .header-wrapper .burger-wrapper .burger-box.show {
  -webkit-transform: translateX(0px);
  -moz-transform: translateX(0px);
  -ms-transform: translateX(0px);
  -o-transform: translateX(0px);
  transform: translateX(0px);
  -webkit-transition: all 0.3s linear;
  -moz-transition: all 0.3s linear;
  transition: all 0.3s linear;
  z-index: 3;
  position: fixed;
  left: 50px;
  top: 30px;
}
header .header-container .header-wrapper .burger-wrapper .burger-box.show > span:nth-child(1) {
  width: 100%;
  transform: translate(0px, 18px) rotate(-45deg);
}
header .header-container .header-wrapper .burger-wrapper .burger-box.show > span:nth-child(2) {
  opacity: 0;
  transform: translateX(-20px);
}
header .header-container .header-wrapper .burger-wrapper .burger-box.show > span:nth-child(3) {
  width: 100%;
  transform: translate(0px, -10px) rotate(45deg);
}
header .header-container .header-wrapper .logo {
  margin: 0 -50px 0 auto;
}
header .header-container .header-wrapper .logo > a {
  display: block;
  width: 100%;
  height: 100%;
  max-width: 100px;
  max-height: 67px;
}
header .header-container .header-wrapper .logo > a > img {
  max-width: 100px;
  max-height: 67px;
  width: 100%;
  height: 100%;
  object-fit: cover;
}
header .popup {
  position: fixed;
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.5);
  top: 0;
  left: 0;
  opacity: 0;
  visibility: hidden;
  overflow-y: auto;
  overflow-x: hidden;
  transition: all 0.7s ease 0s;
  z-index: 9;
}
header .popup .popup-body {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 30px 40px;
}
header .popup .popup-body .popup-content {
  width: 600px;
  background: #FFFFFF;
  position: relative;
  transition: all 0.8s ease 0s;
  opacity: 0;
  transform: perspective(600px) translate(0px, -100%) rotateX(45deg);
}
header .popup .popup-body .popup-content .popup-box {
  padding: 20px 20px 47px 20px;
  position: relative;
}
header .popup .popup-body .popup-content .popup-box .popup-close {
  position: absolute;
  width: 22px;
  height: 22px;
  right: 20px;
  top: 20px;
}
header .popup .popup-body .popup-content .popup-box .popup-close > img {
  width: 100%;
  object-fit: cover;
}
header .popup .popup-body .popup-content .popup-box .popup-descr {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  max-width: 360px;
  margin: 0 auto;
}
header .popup .popup-body .popup-content .popup-box .popup-descr > img {
  width: 130px;
  height: 94px;
  object-fit: cover;
  margin: 0 0 12px 0;
}
header .popup .popup-body .popup-content .popup-box .popup-descr > h4 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 400;
  font-size: 1.375rem;
  line-height: 1.5625rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  text-transform: capitalize;
  margin: 0 0 40px 0;
}
header .popup .popup-body .popup-content .popup-box .popup-descr input {
  font-family: "Satoshi-Regular", sans-serif;
  font-weight: 400;
  font-size: 1.0625rem;
  line-height: 1.4375rem;
  letter-spacing: 0.02em;
  text-align: left;
  color: #000000;
  margin: 0 0 40px 0;
  outline: none;
  border-top: none;
  border-left: none;
  border-right: none;
  border-bottom: 1px solid #000000;
  width: 100%;
  padding: 3px 10px;
}
header .popup .popup-body .popup-content .popup-box .popup-descr input::placeholder {
  font-family: "Satoshi-Regular", sans-serif;
  font-weight: 400;
  font-size: 1.0625rem;
  line-height: 1.4375rem;
  letter-spacing: 0.02em;
  text-align: left;
  color: rgba(0, 0, 0, 0.6);
}
header .popup .popup-body .popup-content .popup-box .popup-descr button {
  font-size: 1rem;
  line-height: 1.375rem;
  padding: 6px 63px;
}
header .popup.open {
  opacity: 1;
  visibility: visible;
}
header .popup.open .popup-body .popup-content {
  transform: perspective(600px) translate(0px, 0%) rotateX(0deg);
  opacity: 1;
}
header .sliding-panel-content {
  position: fixed;
  left: 0;
  top: 0;
  bottom: 0;
  width: 508px;
  height: 100%;
  transform: translateX(-100%);
  transition: all 0.3s linear;
  background: #FFF;
  z-index: 2;
  overflow-y: auto;
  -webkit-overflow-scrolling: touch;
  opacity: 0;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  align-items: center;
  padding: 50px;
}
header .sliding-panel-content.show {
  transform: translateX(0);
  opacity: 1;
}
header .sliding-panel-content > a.logo {
  margin: 0 0 62px 0;
}
header .sliding-panel-content > a.logo > img {
  max-width: 120px;
  max-height: 74px;
  width: 100%;
  object-fit: cover;
}
header .sliding-panel-content > ul {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
  gap: 40px;
  margin: 0 0 50px 0;
}
header .sliding-panel-content > ul > li > a {
  font-family: "Comfortaa", system-ui;
  font-weight: 400;
  font-size: 1.375rem;
  line-height: 1.8125rem;
  letter-spacing: 0.02em;
  color: #000000;
  width: 100%;
  display: inline-block;
  text-align: center;
  transition: color 0.5s ease;
}
header .sliding-panel-content > ul > li > a:hover {
  color: #149926;
}
header .sliding-panel-fade-screen {
  position: fixed;
  left: 0;
  right: 0;
  top: 0;
  bottom: 0;
  transition: all 0.3s linear;
  background: rgba(0, 0, 0, 0.5);
  opacity: 0;
  visibility: hidden;
  z-index: 1;
}
header .sliding-panel-fade-screen.show {
  opacity: 1;
  visibility: visible;
}

@media (min-width: 1919px) {
  header .header-container {
    width: 100%;
  }
}
@media (min-width: 1559px) and (max-width: 1919px) {
  header {
    padding: 8px 0;
  }
  header .header-container .header-wrapper .logo {
    height: 60px;
  }
  header .header-container .header-wrapper .logo > a {
    max-width: 84px;
    max-height: 60px;
  }
  header .header-container .header-wrapper .logo > a > img {
    max-width: 100%;
    max-height: 100%;
    object-fit: contain;
  }
}
@media (min-width: 1080px) and (max-width: 1559px) {
  header {
    padding: 8px 0;
  }
  header .header-container .header-wrapper .burger-wrapper .burger-box {
    height: 50px;
    width: 54px;
  }
  header .header-container .header-wrapper .logo {
    height: 50px;
  }
  header .header-container .header-wrapper .logo > a {
    max-width: 74px;
    max-height: 50px;
  }
  header .header-container .header-wrapper .logo > a > img {
    max-width: 100%;
    max-height: 100%;
    object-fit: contain;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  header {
    padding: 7px 0;
  }
  header .header-container .header-wrapper .burger-wrapper .burger-box {
    width: 50px;
    height: 45px;
  }
  header .header-container .header-wrapper .logo {
    height: 45px;
  }
  header .header-container .header-wrapper .logo > a {
    max-width: 74px;
    max-height: 45px;
  }
  header .header-container .header-wrapper .logo > a > img {
    max-width: 100%;
    max-height: 100%;
    object-fit: contain;
  }
}
@media (max-width: 767px) {
  header {
    padding: 2px 0 7px 0;
  }
  header .header-container {
    max-width: 90%;
  }
  header .header-container .header-wrapper .burger-wrapper .burger-box {
    width: 40px;
    height: 40px;
  }
  header .header-container .header-wrapper .burger-wrapper .burger-box > span:nth-child(2), header .header-container .header-wrapper .burger-wrapper .burger-box > span:nth-child(3) {
    margin-top: 6px;
  }
  header .header-container .header-wrapper .burger-wrapper .burger-box.show {
    left: 15px;
    top: 15px;
  }
  header .header-container .header-wrapper .burger-wrapper .burger-box.show > span:nth-child(1) {
    transform: translate(0px, 6px) rotate(-45deg);
  }
  header .header-container .header-wrapper .logo {
    margin: 0 -40px 0 auto;
  }
  header .header-container .header-wrapper .logo > a {
    max-width: 70px;
    max-height: 49px;
  }
  header .header-container .header-wrapper .logo > a > img {
    max-width: 70px;
    max-height: 49px;
  }
  header .popup .popup-body {
    padding: 20px 10px;
  }
  header .popup .popup-body .popup-content {
    width: 100%;
  }
  header .popup .popup-body .popup-content .popup-box {
    padding: 20px 15px 30px 15px;
  }
  header .popup .popup-body .popup-content .popup-box .popup-descr > img {
    width: 100px;
    height: 64px;
    margin: 0 0 10px 0;
  }
  header .popup .popup-body .popup-content .popup-box .popup-descr > h4 {
    font-size: 1.25rem;
    line-height: 1.5rem;
    margin: 0 0 30px 0;
  }
  header .popup .popup-body .popup-content .popup-box .popup-descr input {
    font-size: 1rem;
    line-height: 1.375rem;
    margin: 0 0 30px 0;
  }
  header .popup .popup-body .popup-content .popup-box .popup-descr button {
    padding: 6px 53px;
  }
  header .sliding-panel-content {
    width: 100%;
    padding: 10px 20px 20px 20px;
  }
  header .sliding-panel-content > a.logo {
    margin: 0 0 44px 0;
  }
  header .sliding-panel-content > a.logo > img {
    max-width: 70px;
    max-height: 44px;
  }
  header .sliding-panel-content > ul {
    gap: 30px;
    margin: 0 0 70px 0;
  }
  header .sliding-panel-content > ul > li > a {
    font-size: 1.25rem;
    line-height: 1.6875rem;
  }
  header .sliding-panel-fade-screen {
    display: none;
  }
}
.footer {
  background: #FAF8F4;
  padding: 50px 0;
}
.footer .footer-wrapper {
  display: flex;
  justify-content: space-between;
  align-items: center;
  gap: 15px;
  max-width: 1106px;
  margin: 0 auto;
}
.footer .footer-wrapper .footer-item {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}
.footer .footer-wrapper .footer-item > h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  line-height: 2.0625rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 30px 0;
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  gap: 7px;
}
.footer .footer-wrapper .footer-item > h3 .fu {
  margin: 0;
}
.footer .footer-wrapper .footer-item > p {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 30px 0;
}
.footer .footer-wrapper .footer-item > p > span {
  font-size: 0.875rem;
  line-height: 1.1875rem;
}
.footer .footer-wrapper .footer-item > a {
  display: block;
}
.footer .footer-wrapper .footer-item > a.email-link {
  font-size: 1.1875rem;
  line-height: 1.625rem;
  letter-spacing: 0.02em;
  text-align: center;
  margin: 0 0 36px 0;
  transition: color 0.5s ease;
}
.footer .footer-wrapper .footer-item > a.email-link:hover {
  color: #149926;
}
.footer .footer-wrapper .footer-item > a.subscribe-link {
  margin: 0 0 33px 0;
}
.footer .footer-wrapper .footer-item > img {
  width: 250px;
  height: 250px;
  border-radius: 50%;
  object-fit: cover;
}
.footer .footer-wrapper .footer-item .mobile-img {
  display: none;
}
.footer .footer-wrapper .footer-item .social-media {
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  gap: 30px;
}
.footer .footer-wrapper .footer-item .social-media > a {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 40px;
  height: 40px;
  transition: stroke 0.5s ease, fill 0.5s ease;
}
.footer .footer-wrapper .footer-item .social-media > a > svg {
  width: 40px;
  height: 40px;
  object-fit: cover;
}
.footer .footer-wrapper .footer-item .social-media > a > svg path {
  transition: stroke 0.5s ease, fill 0.5s ease;
}
.footer .footer-wrapper .footer-item .social-media > a:nth-child(2) > svg {
  width: 34px;
  height: 34px;
}
.footer .footer-wrapper .footer-item .social-media > a.instagram-link:hover > svg path {
  stroke: #000000;
}
.footer .footer-wrapper .footer-item .social-media > a.twitter-link:hover > svg path {
  fill: #000000;
}
.footer .footer-wrapper .footer-item .social-media > a.linkid-link:hover > svg path {
  fill: #000000;
}
.footer .footer-wrapper .footer-item .social-media > a.facebook-link:hover > svg path {
  stroke: #000000;
}

@media (min-width: 1282px) {
  .footer .footer-wrapper .footer-item > h3 {
    font-size: calc(1.875rem + 0.1462558502vw);
    line-height: 2.1875rem;
  }
  .footer .footer-wrapper .footer-item > p {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
  .footer .footer-wrapper .footer-item > p > span {
    font-size: calc(0.875rem + 0.0682527301vw);
    line-height: 1.3125rem;
  }
  .footer .footer-wrapper .footer-item > a.email-link {
    font-size: calc(1.1875rem + 0.0926287051vw);
    line-height: 1.75rem;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  footer .footer-wrapper .footer-item > img {
    width: 200px;
    height: 200px;
  }
}
@media (max-width: 767px) {
  footer {
    padding: 50px 0 30px 0;
  }
  footer .footer-wrapper {
    gap: 25px;
    flex-direction: column;
  }
  footer .footer-wrapper .footer-item > h3 {
    font-size: 1.625rem;
    line-height: 1.8125rem;
  }
  footer .footer-wrapper .footer-item .mobile-img {
    display: block !important;
    margin: 0 0 20px 0;
  }
  footer .footer-wrapper .footer-item .mobile-img > img {
    width: 150px;
    height: 150px;
    object-fit: cover;
  }
  footer .footer-wrapper .footer-item > p {
    font-size: 1.0625rem;
    line-height: 1.375rem;
    margin: 0 0 22px 0;
  }
  footer .footer-wrapper .footer-item > p > span {
    font-size: 0.875rem;
    line-height: 1.125rem;
  }
  footer .footer-wrapper .footer-item .social-media {
    gap: 20px;
  }
  footer .footer-wrapper .footer-item .social-media > a {
    width: 34px;
    height: 34px;
  }
  footer .footer-wrapper .footer-item .social-media > a > svg {
    width: 34px;
    height: 34px;
  }
  footer .footer-wrapper .footer-item:nth-child(2) {
    display: none;
  }
  footer .footer-wrapper .footer-item > a.email-link {
    font-size: 1.0625rem;
    line-height: 1.375rem;
    margin: 0 0 50px 0;
  }
  footer .footer-wrapper .footer-item > a.subscribe-link {
    margin: 0 0 35px 0;
  }
}
.top-banner {
  position: relative;
}
.top-banner > img {
  width: 100%;
  object-fit: cover;
  object-position: center bottom;
}
.top-banner .title {
  width: 100%;
  max-width: 95%;
  position: absolute;
  left: 0;
  right: 0;
  top: 0;
  margin: auto;
  padding: 117px 0;
}
.top-banner .title > h1 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 2.1875rem;
  line-height: 2.4375rem;
  letter-spacing: 0.02em;
  text-align: center;
  text-transform: lowercase;
  margin: 0;
}

@media (min-width: 1919px) {
  .top-banner > img {
    height: calc(100vh - 99px);
  }
}
@media (min-width: 1559px) and (max-width: 1919px) {
  .top-banner > img {
    height: calc(100vh - 76px);
  }
}
@media (min-width: 1080px) and (max-width: 1559px) {
  .top-banner > img {
    height: calc(100vh - 66px);
  }
}
@media (min-width: 1282px) {
  .top-banner .title > h1 {
    font-size: calc(2.1875rem + 0.1706318253vw);
    line-height: 2.5625rem;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  .top-banner > img {
    height: calc(100vh - 59px);
  }
  .top-banner .title {
    padding: 136px 0;
  }
}
@media (max-width: 767px) {
  .top-banner > img {
    height: calc(100vh - 56px);
  }
  .top-banner .title {
    padding: 136px 0;
    max-width: 90%;
  }
  .top-banner .title > h1 {
    font-size: 2.1875rem;
    line-height: 2.8125rem;
  }
}
.experience {
  background: #FAF9F9;
  padding: 50px 0 58px 0;
}
.experience .experience-wrapper {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
}
.experience .experience-wrapper > a {
  margin: 0 0 42px 0;
}
.experience .experience-wrapper > h2 {
  display: flex;
  align-items: center;
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.875rem;
  line-height: 2.0625rem;
  letter-spacing: 0.02em;
  text-align: center;
  text-transform: lowercase;
  color: #000000;
  margin: 0 0 37px 0;
}
.experience .experience-wrapper > h2 > img {
  width: 34px;
  height: 21px;
  mix-blend-mode: multiply;
  object-fit: contain;
}
.experience .experience-wrapper > h2 .fu {
  margin: 0 2px 0 12px;
}
.experience .experience-wrapper > p {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 25px 0;
}
.experience .experience-wrapper > p .fu {
  margin: 0;
}
.experience .experience-wrapper > img {
  max-width: 200px;
  max-height: 144.38px;
  width: 100%;
  height: 100%;
  object-fit: cover;
}

@media (min-width: 1282px) {
  .experience .experience-wrapper > h2 {
    font-size: calc(1.875rem + 0.1462558502vw);
    line-height: 2.1875rem;
  }
  .experience .experience-wrapper > p {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
}
@media (max-width: 767px) {
  .experience {
    padding: 50px 0 53px 0;
  }
  .experience .experience-wrapper > a {
    margin: 0 0 50px 0;
  }
  .experience .experience-wrapper > h2 {
    font-size: 1.625rem;
    line-height: 1.8125rem;
    margin: 0 0 25px 0;
  }
  .experience .experience-wrapper > h2 > img {
    width: 29px;
    height: 18px;
  }
  .experience .experience-wrapper > h2 .fu {
    margin: 0 2px 0 10px;
  }
  .experience .experience-wrapper > p {
    font-size: 1.0625rem;
    line-height: 1.5rem;
    margin: 0 0 20px 0;
  }
  .experience .experience-wrapper > img {
    max-width: 150px;
    max-height: 108px;
  }
}
.about {
  padding: 150px 0 75px 0;
}
.about .about-wrapper {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
}
.about .about-wrapper > h2 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.875rem;
  line-height: 2.0625rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 30px 0;
}
.about .about-wrapper > p {
  font-size: 1.0625rem;
  line-height: 1.4375rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 25px 0;
}
.about .gallery-container {
  max-width: 95%;
  width: 1285px;
  margin: 68px auto 0 auto;
}
.about .gallery-container .full-gallery-slider {
  margin: 0 auto 28px auto;
  height: calc(100vh - 166px);
  width: calc(100% - 50px);
}
.about .gallery-container .full-gallery-slider .slick-list,
.about .gallery-container .full-gallery-slider .slick-track {
  display: flex;
}
.about .gallery-container .full-gallery-slider .slide-item > a {
  display: block;
  width: 100%;
  height: 100%;
}
.about .gallery-container .full-gallery-slider .slide-item > a > img {
  width: 100%;
  object-fit: cover;
  height: calc(100vh - 166px);
}
.about .gallery-container .mini-gallery-slider {
  padding: 0 67px;
}
.about .gallery-container .mini-gallery-slider .slick-list,
.about .gallery-container .mini-gallery-slider .slick-track {
  display: flex;
}
.about .gallery-container .mini-gallery-slider .slick-arrow {
  background: #FFFFFF;
  padding: 0;
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  z-index: 1;
  cursor: pointer;
  transition: all 200ms linear;
  width: 40px;
  height: 40px;
  border: none;
  outline: none;
  display: flex !important;
  justify-content: center;
  align-items: center;
}
.about .gallery-container .mini-gallery-slider .slick-arrow > img {
  width: 40px;
  height: 40px;
  object-fit: cover;
}
.about .gallery-container .mini-gallery-slider .slick-arrow.slick-prev {
  margin: 0 19.5px 0 0;
  left: 0;
}
.about .gallery-container .mini-gallery-slider .slick-arrow.slick-next {
  margin: 0 0 0 19.5px;
  right: 0;
}
.about .gallery-container .mini-gallery-slider .slide-item {
  margin: 0 7.5px;
  cursor: pointer;
}
.about .gallery-container .mini-gallery-slider .slide-item > img {
  width: 100%;
  object-fit: cover;
  max-height: 100px;
  min-height: 100px;
}
.about .social-media {
  margin: 50px 0 0 0 !important;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}
.about .social-media > p {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  text-transform: lowercase;
  margin: 0 0 15px 0;
}
.about .social-media .links {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  gap: 28px;
}
.about .social-media .links > a {
  width: 32px;
  height: 32px;
  display: block;
  transition: stroke 0.5s ease, fill 0.5s ease;
}
.about .social-media .links > a > svg {
  width: 32px;
  height: 32px;
  object-fit: cover;
}
.about .social-media .links > a > svg path {
  transition: stroke 0.5s ease, fill 0.5s ease;
}
.about .social-media .links > a.instagram-link:hover > svg path {
  stroke: #149926;
}
.about .social-media .links > a.twitter-link:hover > svg path {
  fill: #149926;
}
.about .social-media .links > a.linkid-link:hover > svg path {
  fill: #149926;
}
.about .social-media .links > a.facebook-link:hover > svg path {
  stroke: #149926;
}

@media (min-width: 1921px) {
  .about .gallery-container .full-gallery-slider {
    margin: 0 auto 28px auto;
    height: 100%;
  }
  .about .gallery-container .full-gallery-slider .slide-item > a > img {
    width: auto;
    height: 100%;
    margin: 0 auto;
    max-height: 760px;
  }
  .about .gallery-container .mini-gallery-slider .slide-item > img {
    max-height: 90px;
    min-height: 90px;
  }
}
@media (max-width: 1367px) {
  .about .gallery-container {
    width: 1085px;
  }
  .about .gallery-container .mini-gallery-slider .slide-item > img {
    max-height: 80px;
    min-height: 80px;
  }
}
@media (min-width: 1282px) {
  .about .about-wrapper > h2 {
    font-size: calc(1.875rem + 0.1462558502vw);
    line-height: 2.1875rem;
  }
  .about .about-wrapper > p {
    font-size: calc(1.0625rem + 0.0828783151vw);
    line-height: 1.5625rem;
  }
  .about .social-media > p {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
}
@media (min-width: 1080px) and (max-width: 1282px) {
  .about .gallery-container .full-gallery-slider {
    height: calc(100vh - 126px);
    width: 100%;
  }
  .about .gallery-container .full-gallery-slider .slide-item > a > img {
    width: auto;
    margin: 0 auto;
    height: calc(100vh - 126px);
  }
  .about .gallery-container .mini-gallery-slider {
    max-width: 900px;
    width: 100%;
    margin: 0 auto;
  }
  .about .gallery-container .mini-gallery-slider .slide-item > img {
    max-height: 60px;
    min-height: 60px;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  .about {
    padding: 75px 0;
  }
  .about .gallery-container .full-gallery-slider {
    margin: 0 0 28px 0;
    height: 100%;
    width: 100%;
  }
  .about .gallery-container .full-gallery-slider .slide-item > a > img {
    max-height: 500px;
    height: 100%;
  }
  .about .gallery-container .mini-gallery-slider {
    padding: 0 37px;
  }
  .about .gallery-container .mini-gallery-slider .slide-item > img {
    max-height: 100px;
    min-height: 100px;
  }
}
@media (max-width: 767px) {
  .about {
    padding: 50px 0 50px 0;
  }
  .about .about-wrapper > h2 {
    font-size: 1.625rem;
    line-height: 1.6875rem;
    margin: 0 0 25px 0;
  }
  .about .about-wrapper > p {
    font-size: 1.0625rem;
    line-height: 1.5rem;
    margin: 0 0 20px 0;
  }
  .about .gallery-container {
    margin: 40px 0 0 0;
    max-width: 100%;
    width: 100%;
  }
  .about .gallery-container .full-gallery-slider {
    margin: 0 0 14px 0;
    height: 100%;
    width: 100%;
  }
  .about .gallery-container .full-gallery-slider .slide-item > a > img {
    max-height: 400px;
    height: 100%;
  }
  .about .gallery-container .mini-gallery-slider {
    padding: 0 37.5px;
  }
  .about .gallery-container .mini-gallery-slider .slick-arrow {
    width: 30px;
    height: 30px;
  }
  .about .gallery-container .mini-gallery-slider .slick-arrow > img {
    width: 30px;
    height: 30px;
  }
  .about .gallery-container .mini-gallery-slider .slick-arrow.slick-prev {
    margin: 0 7.5px 0 0;
  }
  .about .gallery-container .mini-gallery-slider .slick-arrow.slick-next {
    margin: 0 0 0 7.5px;
  }
  .about .gallery-container .mini-gallery-slider .slide-item > img {
    height: 100%;
    min-height: 60px;
  }
  .about .social-media {
    margin: 50px 0 0 0 !important;
  }
  .about .social-media > p {
    font-size: 1.0625rem;
    line-height: 1.375rem;
    margin: 0 0 17px 0;
  }
  .about .social-media .links {
    gap: 20px;
  }
  .about .social-media .links > a {
    width: 24px;
    height: 24px;
  }
  .about .social-media .links > a > svg {
    width: 24px;
    height: 24px;
  }
}
.reasons {
  padding: 75px 0 130px 0;
}
.reasons .reasons-wrapper {
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 30px;
  max-width: 1209px;
  margin: 0 auto 150px auto !important;
}
.reasons .reasons-wrapper .reasons-img {
  max-width: 800px;
  width: 100%;
}
.reasons .reasons-wrapper .reasons-img > img {
  width: 100%;
  object-fit: cover;
  border-radius: 70px;
  max-height: 560px;
}
.reasons .reasons-wrapper .reasons-descr {
  width: 100%;
  max-width: 325px;
}
.reasons .reasons-wrapper .reasons-descr > h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.875rem;
  line-height: 2.0625rem;
  letter-spacing: 0.02em;
  color: #000000;
  margin: 0 0 30px 0;
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  gap: 5px;
}
.reasons .reasons-wrapper .reasons-descr > ul {
  margin: 0 0 50px 0;
  display: flex;
  flex-direction: column;
  gap: 10px;
}
.reasons .reasons-wrapper .reasons-descr > ul > li {
  font-size: 1.0625rem;
  line-height: 1.4375rem;
  letter-spacing: 0.02em;
  color: #000000;
}
.reasons .butterfly-gallery > h6 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 2rem;
  line-height: 2.3125rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 19px 0;
}
.reasons .butterfly-gallery > p {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.375rem;
  line-height: 3rem;
  letter-spacing: 0.02em;
  text-align: center;
  max-width: 500px;
  margin: 0 auto;
  text-transform: lowercase;
}
.reasons .butterfly-gallery > p > b {
  font-weight: 700;
  border: 2px solid #000000;
  border-radius: 100px;
  padding: 7px 14px;
}
.reasons .butterfly-gallery .images {
  display: flex;
  align-items: center;
  justify-content: center;
  flex-wrap: wrap;
  max-width: 1040px;
  margin: 30px auto 0 auto;
  position: relative;
  z-index: -1;
}
.reasons .butterfly-gallery .images > img {
  width: 100%;
  object-fit: contain;
  max-width: 450px;
}
.reasons .butterfly-gallery .images > img:nth-child(1) {
  margin: 0 36px 0 0;
  max-width: 170px;
}
.reasons .butterfly-gallery .images > img:nth-child(2) {
  margin: 0 49px 0 0;
  max-width: 160px;
}
.reasons .butterfly-gallery .images > img:nth-child(3) {
  margin: 0 15px 0 0;
  max-width: 160px;
}

@media (min-width: 1921px) {
  .reasons .reasons-wrapper {
    gap: 100px;
  }
}
@media (min-width: 1282px) and (max-width: 1920px) {
  .reasons .reasons-wrapper .reasons-descr {
    max-width: 345px;
  }
  .reasons .reasons-wrapper .reasons-descr > h3 {
    font-size: calc(1.875rem + 0.1462558502vw);
    line-height: 2.1875rem;
  }
  .reasons .reasons-wrapper .reasons-descr > ul > li {
    font-size: calc(1.0625rem + 0.0828783151vw);
    line-height: 1.5625rem;
  }
  .reasons .butterfly-gallery > h6 {
    font-size: calc(2rem + 0.1560062402vw);
    line-height: 2.4375rem;
  }
  .reasons .butterfly-gallery > p {
    font-size: calc(1.375rem + 0.1072542902vw);
    line-height: 3rem;
    max-width: 550px;
  }
}
@media (min-width: 1080px) and (max-width: 1367px) {
  .reasons .reasons-wrapper {
    justify-content: flex-start;
    gap: 50px;
  }
  .reasons .reasons-wrapper .reasons-img {
    max-width: 750px;
  }
  .reasons .butterfly-gallery .images > img:nth-child(1) {
    margin: 0 32px 0 0;
  }
  .reasons .butterfly-gallery .images > img:nth-child(2) {
    margin: 0 32px 0 0;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  .reasons {
    padding: 75px 0;
  }
  .reasons .reasons-wrapper {
    margin: 0 auto 75px auto !important;
    flex-direction: column;
  }
  .reasons .reasons-wrapper .reasons-img {
    max-width: 100%;
  }
  .reasons .reasons-wrapper .reasons-descr {
    max-width: 100%;
    text-align: center;
  }
  .reasons .reasons-wrapper .reasons-descr > h3 {
    justify-content: center;
  }
}
@media (max-width: 767px) {
  .reasons {
    padding: 50px 0 35px 0;
  }
  .reasons .reasons-wrapper {
    margin: 0 auto 75px auto !important;
    flex-direction: column;
    gap: 37px;
  }
  .reasons .reasons-wrapper .reasons-img {
    max-width: 100%;
  }
  .reasons .reasons-wrapper .reasons-img > img {
    max-height: 350px;
    height: 100%;
  }
  .reasons .reasons-wrapper .reasons-descr {
    max-width: 100%;
    text-align: center;
  }
  .reasons .reasons-wrapper .reasons-descr > h3 {
    font-size: 1.5rem;
    line-height: 1.6875rem;
    margin: 0 0 25px 0;
    justify-content: center;
  }
  .reasons .reasons-wrapper .reasons-descr > ul > li {
    font-size: 1.0625rem;
    line-height: 1.5rem;
  }
  .reasons .butterfly-gallery > h6 {
    font-size: 1.5rem;
    line-height: 1.6875rem;
  }
  .reasons .butterfly-gallery > p {
    font-size: 0.75rem;
    line-height: 1.875rem;
    max-width: 400px;
  }
  .reasons .butterfly-gallery .images {
    margin: 25px auto 0 auto;
    flex-direction: column;
  }
  .reasons .butterfly-gallery .images > img {
    max-width: 150px;
    max-height: 108px;
  }
  .reasons .butterfly-gallery .images > img:nth-child(1), .reasons .butterfly-gallery .images > img:nth-child(2), .reasons .butterfly-gallery .images > img:nth-child(3) {
    display: none;
  }
}
.experience-anchors {
  background: #FAF8F4;
  padding: 150px 0 75px 0;
}
.experience-anchors h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.875rem;
  line-height: 2.0625rem;
  letter-spacing: 0.02em;
  text-align: center;
  text-transform: lowercase;
  margin: 0 0 35px 0;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-wrap: wrap;
}
.experience-anchors .anchors-wrapper {
  display: flex;
  flex-direction: column;
  gap: 100px;
}
.experience-anchors .anchors-wrapper .anchors-items {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  align-items: center;
  gap: 25px;
}
.experience-anchors .anchors-wrapper .anchors-items .anchor-item {
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 10px;
  width: 32%;
}
.experience-anchors .anchors-wrapper .anchors-items .anchor-item > img {
  width: 100%;
  object-fit: cover;
  border-radius: 70px;
  min-height: 409px;
  max-height: 409px;
}
.experience-anchors .anchors-wrapper .anchors-items .anchor-item > a > svg {
  width: 20px;
  height: 20px;
  object-fit: cover;
  transition: background 0.5s ease, color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
}
.experience-anchors .anchors-wrapper .anchors-items .anchor-item > a > svg path {
  transition: background 0.5s ease, color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
}
.experience-anchors .anchors-wrapper .anchors-items .anchor-item > a:hover > svg {
  transform: translateX(5px);
}
.experience-anchors .anchors-wrapper .anchors-items .anchor-item > a:hover > svg path {
  fill: #FFFFFF;
}
.experience-anchors .anchors-wrapper .anchors-content {
  display: flex;
  flex-direction: column;
  gap: 100px;
  max-width: 1178px;
  margin: 0 auto;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .divider {
  display: flex;
  align-items: center;
  gap: 15px;
  max-width: 910px;
  margin: 0 auto 50px auto;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .divider .line {
  background: #ACACAC;
  height: 1px;
  width: 100%;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .divider > img {
  max-width: 80px;
  max-height: 58px;
  width: 100%;
  height: 100%;
  object-fit: cover;
  mix-blend-mode: multiply;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info {
  max-width: 850px;
  margin: 0 auto;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info > h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.6875rem;
  line-height: 1.9375rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  text-transform: lowercase;
  margin: 0 0 25px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info > p {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 25px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info > p .fu {
  margin: 0;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info > ul > li {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 10px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info > ul > li .fu {
  margin: 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .divider {
  display: flex;
  align-items: center;
  gap: 15px;
  max-width: 910px;
  margin: 0 auto 50px auto;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .divider .line {
  background: #ACACAC;
  height: 1px;
  width: 100%;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .divider > img {
  max-width: 80px;
  max-height: 58px;
  width: 100%;
  height: 100%;
  object-fit: cover;
  mix-blend-mode: multiply;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info > h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.6875rem;
  line-height: 1.9375rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  text-transform: lowercase;
  margin: 0 0 58px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps {
  max-width: 850px;
  margin: 0 auto 105px auto;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps > p {
  font-size: 1.4375rem;
  line-height: 1.875rem;
  letter-spacing: 0.02em;
  color: #000000;
  margin: 0 0 5px 0;
  text-transform: lowercase;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps > p > span {
  font-size: 0.9375rem;
  line-height: 1.875rem;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps > img {
  width: 41px;
  height: 41px;
  object-fit: cover;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box {
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 4px;
  position: relative;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p {
  font-size: 1.4375rem;
  line-height: 1.875rem;
  letter-spacing: 0.02em;
  color: #000000;
  margin: 0 0 10px 0;
  position: relative;
  text-transform: lowercase;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p > span {
  font-size: 0.8125rem;
  line-height: 0.8125rem;
  letter-spacing: 0.02em;
  color: #951ABE;
  margin: 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p::after, .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p::before {
  content: "";
  position: absolute;
  background-image: url(../img/svg/airplane.svg);
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  width: 35px;
  height: 35px;
  top: 0;
  bottom: 0;
  margin: auto;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p::after {
  right: -50px;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p::before {
  left: -50px;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(3) {
  margin: 0 0 7px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(3)::before, .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(3)::after {
  content: none;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(4) {
  margin: 0 0 15px 0;
  font-size: 0.8125rem;
  line-height: 0.8125rem;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(4)::before, .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(4)::after {
  content: none;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p:last-child {
  margin: 0 0 5px 0 !important;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > img {
  width: 20px;
  height: 20px;
  object-fit: cover;
  transform: rotate(90deg);
  margin: 0 0 5px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > img:nth-child(5) {
  margin: 0 0 10px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list {
  display: flex;
  justify-content: space-between;
  gap: 126px;
  max-width: 1084px;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item {
  width: 100%;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item > h4 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 400;
  font-size: 1.25rem;
  line-height: 1.375rem;
  letter-spacing: 0.02em;
  color: #000000;
  margin: 0 0 17px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item ul {
  display: flex;
  flex-direction: column;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item ul li {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  display: flex;
  gap: 11px;
  margin: 0 0 12px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item ul li > img {
  max-width: 22px;
  max-height: 17px;
  width: 100%;
  height: 100%;
  object-fit: contain;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item ul li > span {
  margin-top: -5px;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item:first-child ul li > img {
  max-height: 16px;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .hidden-content {
  display: none;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-more,
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-less {
  font-size: 0.9375rem;
  line-height: 1.25rem;
  letter-spacing: 0.09em;
  text-align: center;
  color: #000000;
  cursor: pointer;
  display: flex;
  align-items: center;
  gap: 18px;
  text-transform: uppercase;
  transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
  margin: 20px 0 0 0;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-more > svg,
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-less > svg {
  width: 18px;
  height: 20px;
  object-fit: cover;
  transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-more > svg path,
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-less > svg path {
  transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-more:hover,
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-less:hover {
  color: #149926;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-more:hover > svg,
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-less:hover > svg {
  transform: translateX(5px);
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-more:hover > svg path,
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-less:hover > svg path {
  fill: #149926;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .hidden-readmore {
  display: none;
}
.experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item .read-less:hover > svg {
  transform: translateX(-5px);
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .divider {
  display: flex;
  align-items: center;
  gap: 15px;
  max-width: 910px;
  margin: 0 auto 50px auto;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .divider .line {
  background: #ACACAC;
  height: 1px;
  width: 100%;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .divider > img {
  max-width: 80px;
  max-height: 58px;
  width: 100%;
  height: 100%;
  object-fit: cover;
  mix-blend-mode: multiply;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info {
  max-width: 850px;
  margin: 0 auto;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info > h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.6875rem;
  line-height: 1.9375rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  text-transform: lowercase;
  margin: 0 0 25px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info > p {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 0 25px 0;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info > p .fu {
  margin: 0;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info .butterfly-items {
  margin: 50px 0 0 0;
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 70px;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info .butterfly-items .butterfly-item {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info .butterfly-items .butterfly-item > img {
  width: 100%;
  height: 100%;
  max-height: 144px;
  min-height: 144px;
  object-fit: cover;
}
.experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info .butterfly-items .butterfly-item > p {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  text-transform: lowercase;
  margin: 0;
}
.experience-anchors .anchors-flex {
  display: none;
}

@media (min-width: 1282px) {
  .experience-anchors h3 {
    font-size: calc(1.875rem + 0.1462558502vw);
    line-height: 2.1875rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info > h3 {
    font-size: calc(1.6875rem + 0.1316302652vw);
    line-height: 2.0625rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info > p {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .first-anchor .anchor-info > ul > li {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info > h3 {
    font-size: calc(1.6875rem + 0.1316302652vw);
    line-height: 2.0625rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps > p {
    font-size: calc(1.4375rem + 0.1121294852vw);
    line-height: 2rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps > p > span {
    font-size: calc(0.9375rem + 0.0731279251vw);
    line-height: 2rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box > p {
    font-size: calc(0.9375rem + 0.0731279251vw);
    line-height: 2rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .steps .steps-box .steps-line > p {
    font-size: calc(1.4375rem + 0.1121294852vw);
    line-height: 2rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item > h4 {
    font-size: calc(1.25rem + 0.0975039002vw);
    line-height: 1.5rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item ul li {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info > h3 {
    font-size: calc(1.6875rem + 0.1316302652vw);
    line-height: 2.0625rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info > p {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
  .experience-anchors .anchors-wrapper .anchors-content .third-anchor .anchor-info .butterfly-items .butterfly-item > p {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
}
@media (min-width: 1080px) and (max-width: 1282px) {
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item ul li > img {
    max-height: 15px;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item:first-child ul li > img {
    max-height: 15px;
  }
}
@media (min-width: 1080px) and (max-width: 1367px) {
  .experience-anchors .anchors-wrapper .anchors-items .anchor-item {
    width: 31.7%;
  }
  .experience-anchors .anchors-wrapper .anchors-items .anchor-item > img {
    min-height: 330px;
    max-height: 330px;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  .experience-anchors {
    padding: 75px 0;
  }
  .experience-anchors .anchors-wrapper .anchors-items {
    gap: 30px 15px;
  }
  .experience-anchors .anchors-wrapper .anchors-items .anchor-item {
    width: 48%;
  }
  .experience-anchors .anchors-wrapper .anchors-items .anchor-item > img {
    min-height: 283px;
    max-height: 283px;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list {
    gap: 60px;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item ul li > span {
    margin-top: -4px;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item ul li > img {
    max-height: 15px;
  }
  .experience-anchors .anchors-wrapper .anchors-content .second-anchor .anchor-info .list .list-item:first-child ul li > img {
    max-height: 15px;
  }
}
@media (max-width: 767px) {
  .experience-anchors {
    padding: 80px 0;
  }
  .experience-anchors h3 {
    font-size: 1.5rem;
    line-height: 1.6875rem;
  }
  .experience-anchors .anchors-wrapper {
    display: none;
  }
  .experience-anchors .anchors-flex {
    display: block;
  }
  .experience-anchors .anchors-flex .anchors-items {
    display: flex;
    flex-wrap: wrap;
    gap: 50px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box {
    width: 100%;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor-item {
    display: flex;
    flex-direction: column;
    align-items: center;
    gap: 6px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor-item > img {
    width: 100%;
    object-fit: cover;
    border-radius: 70px;
    min-height: 278px;
    max-height: 278px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor-item > a {
    font-family: "Satoshi-Regular", sans-serif;
    font-weight: 400;
    font-size: 0.8125rem;
    line-height: 1.125rem;
    letter-spacing: 0.09em;
    text-align: center;
    color: #000000;
    background: #FFFFFF;
    border: 1px solid #000000;
    padding: 10px 13px 10px 43px;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 14px;
    text-transform: uppercase;
    transition: background 0.5s ease, color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor-item > a:hover {
    background: #149926;
    border: 1px solid #149926;
    color: #FFFFFF;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor-item > a > svg {
    width: 14px;
    height: 14px;
    object-fit: cover;
    transition: background 0.5s ease, color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor-item > a > svg path {
    transition: background 0.5s ease, color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor-item > a:hover > svg {
    transform: translateX(5px);
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor-item > a:hover > svg path {
    fill: #FFFFFF;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor {
    display: none;
    margin: 50px 0 25px 0 !important;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor.show-block {
    display: block;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor .divider {
    display: flex;
    align-items: center;
    gap: 15px;
    max-width: 100%;
    margin: 0 auto 20px auto;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor .divider .line {
    background: #ACACAC;
    height: 1px;
    width: 100%;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor .divider > img {
    max-width: 80px;
    max-height: 58px;
    width: 100%;
    height: 100%;
    object-fit: cover;
    mix-blend-mode: multiply;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor .anchor-info > h3 {
    font-family: "Comfortaa", sans-serif;
    font-weight: 300;
    font-size: 1.5rem;
    line-height: 1.6875rem;
    letter-spacing: 0.02em;
    text-align: center;
    color: #000000;
    text-transform: lowercase;
    margin: 0 0 25px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor .anchor-info > p {
    font-size: 1.0625rem;
    line-height: 1.5rem;
    letter-spacing: 0.02em;
    text-align: center;
    color: #000000;
    margin: 0 0 25px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .anchor .anchor-info > p .fu {
    margin: 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .first-anchor .anchor-info > ul > li {
    font-size: 1.0625rem;
    line-height: 1.5rem;
    letter-spacing: 0.02em;
    text-align: center;
    color: #000000;
    margin: 0 0 10px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .first-anchor .anchor-info > ul > li .fu {
    margin: 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info > h3 {
    margin: 0 0 50px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps {
    margin: 0 auto 50px auto;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    text-align: center;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps > p {
    font-size: 1.125rem;
    line-height: 2rem;
    letter-spacing: 0.02em;
    color: #000000;
    margin: 0 0 5px 0;
    text-transform: lowercase;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps > p > span {
    font-size: 0.9375rem;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps > img {
    width: 31px;
    height: 31px;
    object-fit: cover;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box {
    display: flex;
    flex-direction: column;
    align-items: center;
    position: relative;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box > p {
    font-size: 0.9375rem;
    line-height: 1.25rem;
    letter-spacing: 0.02em;
    color: #000000;
    margin: 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box > p > span {
    font-size: 1.0625rem;
    line-height: 2rem;
    color: #951ABE;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line {
    display: flex;
    align-items: center;
    flex-direction: column;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p {
    font-size: 1.0625rem;
    line-height: 1.375rem;
    letter-spacing: 0.02em;
    color: #000000;
    margin: 0 0 10px 0;
    position: relative;
    text-transform: lowercase;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p::after, .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p::before {
    content: "";
    position: absolute;
    background-image: url(../img/svg/airplane.svg);
    background-repeat: no-repeat;
    background-position: center;
    background-size: cover;
    width: 25px;
    height: 25px;
    top: 0;
    bottom: 0;
    margin: auto;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p::after {
    right: -30px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p::before {
    left: -30px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(3) {
    margin: 0 0 7px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(3)::before, .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(3)::after {
    content: none;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(4) {
    margin: 0 0 15px 0;
    font-size: 0.8125rem;
    line-height: 0.8125rem;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(4)::before, .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p:nth-child(4)::after {
    content: none;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p:last-child {
    margin: 0 0 5px 0 !important;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > p > span {
    font-size: 0.8125rem;
    line-height: 0.8125rem;
    color: #951ABE;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > img {
    width: 20px;
    height: 20px;
    object-fit: cover;
    transform: rotate(90deg);
    margin: 0 0 5px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .steps .steps-box .steps-line > img:nth-child(5) {
    margin: 0 0 10px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list {
    display: flex;
    flex-direction: column;
    gap: 40px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item > h4 {
    font-family: "Comfortaa", sans-serif;
    font-weight: 400;
    font-size: 1.0625rem;
    line-height: 1.1875rem;
    letter-spacing: 0.02em;
    color: #000000;
    margin: 0 0 16px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item ul {
    display: flex;
    flex-direction: column;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item ul li {
    font-size: 1.0625rem;
    line-height: 1.625rem;
    letter-spacing: 0.02em;
    display: flex;
    gap: 5px;
    margin: 0 0 10px 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item ul li > img {
    max-width: 15px;
    max-height: 15px;
    width: 100%;
    height: 100%;
    object-fit: contain;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item ul li > span {
    margin-top: -7px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item:first-child ul li > span {
    margin-top: -4px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .hidden-content {
    display: none;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-more,
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-less {
    font-size: 0.75rem;
    line-height: 1rem;
    letter-spacing: 0.09em;
    text-align: center;
    color: #000000;
    cursor: pointer;
    display: flex;
    align-items: center;
    gap: 10px;
    text-transform: uppercase;
    transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
    margin: 7px 0 0 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-more > svg,
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-less > svg {
    width: 14px;
    height: 16px;
    object-fit: cover;
    transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-more > svg path,
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-less > svg path {
    transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-more:hover,
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-less:hover {
    color: #149926;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-more:hover > svg,
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-less:hover > svg {
    transform: translateX(5px);
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-more:hover > svg path,
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-less:hover > svg path {
    fill: #149926;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .hidden-readmore {
    display: none;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-less {
    margin: 17px 0 0 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .second-anchor .anchor-info .list .list-item .read-less:hover > svg {
    transform: translateX(-5px);
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .third-anchor .anchor-info .butterfly-items {
    margin: 25px 0 0 0;
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 35px 58px;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .third-anchor .anchor-info .butterfly-items .butterfly-item {
    display: flex;
    flex-direction: column;
    align-items: center;
    text-align: center;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .third-anchor .anchor-info .butterfly-items .butterfly-item > img {
    width: 100%;
    height: 100%;
    max-height: 101px;
    min-height: 101px;
    object-fit: cover;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .third-anchor .anchor-info .butterfly-items .butterfly-item > p {
    font-size: 1.0625rem;
    line-height: 1.375rem;
    letter-spacing: 0.02em;
    text-align: center;
    color: #000000;
    text-transform: lowercase;
    margin: 0;
  }
  .experience-anchors .anchors-flex .anchors-items .anchor-item-box .third-anchor .anchor-info .butterfly-items .butterfly-item:last-child {
    display: none;
  }
}
.video-content {
  background: linear-gradient(to bottom, #FAF8F4 97.5%, #FFFFFF 2.5%);
  padding: 75px 0 0 0;
}
.video-content .video-wrapper {
  margin: 0 auto 125px auto;
  max-width: 1200px;
}
.video-content .video-wrapper .video {
  position: relative;
  padding-top: 56.25%;
  height: 0;
}
.video-content .video-wrapper .video > video {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
}
.video-content a {
  margin: 0 auto;
  display: flex;
  justify-content: center;
  align-items: center;
  width: max-content;
}

@media (min-width: 767px) and (max-width: 1080px) {
  .video-content {
    background: linear-gradient(to bottom, #FAF8F4 96.5%, #FFFFFF 3.5%);
  }
  .video-content .video-wrapper {
    margin: 0 auto 75px auto;
  }
}
@media (max-width: 767px) {
  .video-content {
    background: linear-gradient(to bottom, #FAF8F4 94%, #FFFFFF 6%);
    padding: 20px 0 0 0;
  }
  .video-content .container {
    max-width: 100%;
  }
  .video-content .video-wrapper {
    margin: 0 auto 75px auto;
  }
  .video-content a {
    max-width: 90%;
  }
}
.cards {
  padding: 150px 0 199px 0;
}
.cards .cards-wrapper {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  gap: 150px;
  max-width: 1450px;
  margin: 0 auto;
}
.cards .cards-wrapper .card-item {
  display: flex;
  flex-direction: column;
}
.cards .cards-wrapper .card-item .img {
  margin: 0 0 20px 0;
}
.cards .cards-wrapper .card-item .img > img {
  width: 100%;
  object-fit: cover;
  border-radius: 70px;
  min-height: 550px;
  max-height: 550px;
}
.cards .cards-wrapper .card-item .text {
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  height: auto;
  min-height: 404px;
  padding: 0 25px;
}
.cards .cards-wrapper .card-item .text .text-visible {
  transition: all 0.3s ease;
}
.cards .cards-wrapper .card-item .text h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.875rem;
  line-height: 2.0625rem;
  letter-spacing: 0.02em;
  text-align: left;
  color: #000000;
  margin: 0 0 15px 0;
}
.cards .cards-wrapper .card-item .text p {
  font-size: 1.125rem;
  line-height: 1.5rem;
  letter-spacing: 0.02em;
  color: #000000;
  margin: 0 0 25px 0;
}
.cards .cards-wrapper .card-item .text p > span {
  font-size: 1.25rem;
  line-height: 1.6875rem;
  display: flex;
  align-items: center;
  flex-wrap: wrap;
}
.cards .cards-wrapper .card-item .text p > span .fu {
  width: 30px;
  height: 18px;
}
.cards .cards-wrapper .card-item .text p > a {
  border-bottom: 1px solid #951ABE;
}
.cards .cards-wrapper .card-item .text p:last-child {
  margin: 0 0 25px 0 !important;
}
.cards .cards-wrapper .card-item .hidden-content {
  display: none;
}
.cards .cards-wrapper .card-item .read-more, .cards .cards-wrapper .card-item .read-less {
  font-family: "Satoshi-Regular", sans-serif;
  font-weight: 400;
  font-size: 0.9375rem;
  line-height: 1.25rem;
  letter-spacing: 0.09em;
  text-align: center;
  color: #000000;
  cursor: pointer;
  display: flex;
  align-items: center;
  justify-content: flex-start;
  gap: 10px;
  text-transform: uppercase;
  margin: 25px 0 0 0;
  transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
}
.cards .cards-wrapper .card-item .read-more > svg, .cards .cards-wrapper .card-item .read-less > svg {
  width: 20px;
  height: 20px;
  object-fit: cover;
  transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
}
.cards .cards-wrapper .card-item .read-more > svg path, .cards .cards-wrapper .card-item .read-less > svg path {
  transition: color 0.5s ease, transform 0.5s ease, fill 0.5s ease;
}
.cards .cards-wrapper .card-item .read-more:hover, .cards .cards-wrapper .card-item .read-less:hover {
  color: #149926;
}
.cards .cards-wrapper .card-item .read-more:hover > svg, .cards .cards-wrapper .card-item .read-less:hover > svg {
  transform: translateX(5px);
}
.cards .cards-wrapper .card-item .read-more:hover > svg path, .cards .cards-wrapper .card-item .read-less:hover > svg path {
  fill: #149926;
}
.cards .cards-wrapper .card-item .hidden-readmore {
  display: none;
}
.cards .cards-wrapper .card-item .read-less {
  margin: 50px 0 0 0;
}
.cards .cards-wrapper .card-item .read-less:hover > svg {
  transform: translateX(-5px);
}

@media (min-width: 1368px) and (max-width: 1600px) {
  .cards .cards-wrapper {
    gap: 60px;
  }
  .cards .cards-wrapper .card-item .text {
    min-height: 430px;
    padding: 0 45px;
  }
}
@media (min-width: 1282px) and (max-width: 1367px) {
  .cards .cards-wrapper .card-item .text {
    min-height: 430px;
    padding: 0 15px;
  }
}
@media (max-width: 1281px) {
  .cards .cards-wrapper .card-item .text {
    min-height: 408px;
    padding: 0;
  }
}
@media (min-width: 1282px) {
  .cards .cards-wrapper .card-item .text h3 {
    font-size: calc(1.875rem + 0.1462558502vw);
    line-height: 2.1875rem;
  }
  .cards .cards-wrapper .card-item .text p {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 1.625rem;
  }
  .cards .cards-wrapper .card-item .text p > span {
    font-size: calc(1.25rem + 0.0975039002vw);
    line-height: 1.8125rem;
  }
}
@media (min-width: 1080px) and (max-width: 1367px) {
  .cards .cards-wrapper {
    gap: 40px;
  }
  .cards .cards-wrapper .card-item .img > img {
    min-height: 450px;
    max-height: 450px;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  .cards {
    padding: 75px 0;
  }
  .cards .cards-wrapper {
    gap: 50px;
  }
  .cards .cards-wrapper .card-item .img > img {
    min-height: 430px;
    max-height: 430px;
  }
}
@media (max-width: 767px) {
  .cards {
    padding: 75px 0 50px 0;
  }
  .cards .cards-wrapper {
    gap: 50px;
    grid-template-columns: repeat(1, 1fr);
  }
  .cards .cards-wrapper .card-item .img {
    margin: 0 0 25px 0;
  }
  .cards .cards-wrapper .card-item .img > img {
    min-height: 340px;
    max-height: 340px;
  }
  .cards .cards-wrapper .card-item .text {
    margin: 0 0 20px 0;
  }
  .cards .cards-wrapper .card-item .text h3 {
    font-size: 1.5rem;
    line-height: 1.6875rem;
    text-align: center;
  }
  .cards .cards-wrapper .card-item .text p {
    font-size: 1.0625rem;
    line-height: 1.5rem;
    margin: 0 0 20px 0;
  }
  .cards .cards-wrapper .card-item .text p:last-child {
    margin: 0 0 20px 0 !important;
  }
  .cards .cards-wrapper .card-item .text p > span {
    font-size: 1.0625rem;
    line-height: 1.375rem;
  }
  .cards .cards-wrapper .card-item .text p > span .fu {
    width: 19px;
    height: 12px;
  }
  .cards .cards-wrapper .card-item .text p.sub-title {
    text-align: center;
  }
  .cards .cards-wrapper .card-item .read-more, .cards .cards-wrapper .card-item .read-less {
    font-size: 0.875rem;
    line-height: 1.125rem;
    margin: 0;
  }
  .cards .cards-wrapper .card-item .read-more > svg, .cards .cards-wrapper .card-item .read-less > svg {
    width: 14px;
    height: 16px;
  }
}
.reviews {
  background: #FAF8F4;
  padding: 140px 0 129px 0;
}
.reviews h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.875rem;
  line-height: 2.0625rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  text-transform: lowercase;
  margin: 0 0 64px 0;
}
.reviews .reviews-slider {
  max-width: 1143px;
  margin: 0 auto;
}
.reviews .reviews-slider .slick-list,
.reviews .reviews-slider .slick-track {
  display: flex;
}
.reviews .reviews-slider .slick-arrow {
  background: #FAF8F4;
  padding: 0;
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  z-index: 1;
  cursor: pointer;
  transition: all 200ms linear;
  width: 40px;
  height: 40px;
  border: none;
  outline: none;
  display: flex !important;
  justify-content: center;
  align-items: center;
}
.reviews .reviews-slider .slick-arrow.slick-next {
  right: 0;
}
.reviews .reviews-slider .slick-arrow.slick-prev {
  left: 0;
}
.reviews .reviews-slider .slide {
  margin: 0 150px;
}
.reviews .reviews-slider .slide > p {
  font-size: 1.125rem;
  line-height: 1.875rem;
  letter-spacing: 0.02em;
  text-align: center;
  color: #000000;
  margin: 0 auto 9px auto;
  max-width: 763px;
}
.reviews .reviews-slider .slide > p > span {
  font-family: "Satoshi-LightItalic", sans-serif;
  font-style: italic;
  font-weight: 300;
  font-size: 1rem;
  line-height: 1.375rem;
  letter-spacing: 0.02em;
}
.reviews .slider-arrows {
  display: none;
}
.reviews img {
  max-width: 180px;
  max-height: 130px;
  width: 100%;
  object-fit: contain;
  margin: 0 auto;
  display: flex;
  justify-content: center;
}

@media (min-width: 1282px) {
  .reviews h3 {
    font-size: calc(1.875rem + 0.1462558502vw);
    line-height: 2.1875rem;
  }
  .reviews .reviews-slider .slide > p {
    font-size: calc(1.125rem + 0.0877535101vw);
    line-height: 2rem;
  }
  .reviews .reviews-slider .slide > p > span {
    font-size: calc(1rem + 0.0780031201vw);
    line-height: 1.5rem;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  .reviews {
    padding: 75px 0;
  }
  .reviews .reviews-slider .slide {
    margin: 0 90px;
  }
}
@media (max-width: 767px) {
  .reviews {
    padding: 42px 0 35px 0;
  }
  .reviews h3 {
    font-size: 1.5rem;
    line-height: 1.685rem;
    margin: 0 auto 54px auto;
    max-width: 283px;
  }
  .reviews .reviews-slider .slide {
    margin: 0 10px;
  }
  .reviews .reviews-slider .slide > p {
    font-size: 1.0625rem;
    line-height: 1.5rem;
    margin: 0 auto 30px auto;
  }
  .reviews .reviews-slider .slide > p > span {
    font-size: 1rem;
    line-height: 1.3125rem;
  }
  .reviews .slider-arrows {
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 74px;
    margin: 30px 0;
  }
  .reviews .slider-arrows .slick-arrow {
    background: #FAF8F4;
    padding: 0;
    cursor: pointer;
    width: 24px;
    height: 24px;
    border: none;
    outline: none;
  }
  .reviews .slider-arrows .slick-arrow > img {
    width: 24px;
    height: 24px;
    object-fit: cover;
  }
  .reviews img {
    max-width: 150px;
    max-height: 108px;
  }
}
.contacts {
  padding: 150px 0;
}
.contacts .contacts-wrapper {
  display: flex;
  justify-content: space-between;
  align-items: center;
  gap: 15px;
  max-width: 1516px;
  margin: 0 auto;
}
.contacts .contacts-wrapper .contacts-info {
  max-width: 315px;
}
.contacts .contacts-wrapper .contacts-info > h3 {
  font-family: "Comfortaa", sans-serif;
  font-weight: 300;
  font-size: 1.875rem;
  line-height: 2.0625rem;
  letter-spacing: 0.02em;
  text-align: left;
  color: #000000;
  text-transform: lowercase;
  margin: 0 0 30px 0;
}
.contacts .contacts-wrapper .contacts-info > p {
  font-size: 1.0625rem;
  line-height: 1.375rem;
  letter-spacing: 0.02em;
  text-align: left;
  color: #000000;
  margin: 0;
}
.contacts .contacts-wrapper .contacts-map {
  max-width: 1100px;
  width: 100%;
}
.contacts .contacts-wrapper .contacts-map > iframe {
  border: 0;
  width: 100%;
  height: 100%;
  min-height: 547px;
}

@media (min-width: 1282px) {
  .contacts .contacts-wrapper .contacts-info {
    max-width: 350px;
  }
  .contacts .contacts-wrapper .contacts-info > h3 {
    font-size: calc(1.875rem + 0.1462558502vw);
    line-height: 2.1875rem;
  }
  .contacts .contacts-wrapper .contacts-info > p {
    font-size: calc(1.0625rem + 0.0828783151vw);
    line-height: 1.5rem;
  }
}
@media (min-width: 1080px) and (max-width: 1367px) {
  .contacts .contacts-wrapper .contacts-map > iframe {
    min-height: 470px;
  }
}
@media (min-width: 767px) and (max-width: 1080px) {
  .contacts {
    padding: 75px 0;
  }
}
@media (max-width: 767px) {
  .contacts {
    padding: 100px 0;
  }
  .contacts .container {
    max-width: 100%;
  }
  .contacts .contacts-wrapper {
    gap: 25px;
    flex-direction: column;
  }
  .contacts .contacts-wrapper .contacts-info {
    max-width: 90%;
    margin: 0 auto;
  }
  .contacts .contacts-wrapper .contacts-info > h3 {
    font-size: 1.5rem;
    line-height: 1.6875rem;
    margin: 0 0 25px 0;
    text-align: center;
  }
  .contacts .contacts-wrapper .contacts-info > p {
    font-size: 1.0625rem;
    text-align: center;
  }
  .contacts .contacts-wrapper .contacts-map {
    max-width: 100%;
  }
  .contacts .contacts-wrapper .contacts-map > iframe {
    min-height: 321px;
  }
}

/*# sourceMappingURL=style.cs.map */
