/* BEGIN CUSTOM CSS */
/* Main Tile Parts */
.title {color: #32CD32;} /* Title is the text at the top of the tiles */
.footer {color: #32CD32;} /* Footer is the text at the bottom of the tiles and includes the thermometer icon for Temperature tiles */
 
/* Pop-Up Menus */
.ui-li-static {
height:150px;
width:300px;
font-size:40px;} /* This will increase the pop-up menu size and also increase the text in it. These menus are used for Mode selection and Routines. */
 
/* Modes using Font Awesome */
/* Although all you see is a box here, this is actually a Font Awesome icon. You can put any Font Awesome icon from the cheatsheet in here and have it displayed. It goes in between the 2 sets of double quotes. */
.icon.Home i::before {content: " ";} 
.icon.Away i::before {content: " Away";}
.icon.Night i::before {content: " Night";}
.mode.Away .fa {color: Green;} /* This will change the color for your Font Awesome icons. You can change it per mode. */
.mode.Home .fa {color: Black;}
.mode.Night .fa {color: Black;}
 
/* Modes using Custom Pic URLs */
.icon.Home i::before {content: url(http://www.yourdomainhere);} /* You can use images instead of Font Awesome icons. If the icons are not centered, you can use the code on the next line to move it around. */
.icon.Away i::before {content: url(http://www.yourdomainhere); position: relative; left: -18px; top: 20px;} /* The extra code here is for adjusting position of the icon. It references left and top locations and is counted in pixels (px). */
.icon.Night i::before {content: url(http://www.yourdomainhere);}
 
/* Non-specific tile changes. Note: These will change ALL tiles of that type. Look further down to find out how to change specific individual tiles of a certain type. You can add the code for content to any of these items and it will change the content for ALL devices of that specific type. My example will have it only for Other Dashboards. I will also have an example on the Presence sensor tile showing you can have one type of content for Active and a different for Inactive. */
 
/* Change Title Color When Active */
.switch.tile.active .title { color: red;}  /*This will change the Title on the given tile type to the color specified only when active. This could be used with other tile types that show On/Off or Active/Inactive such as lights, dimmerlights, dimmers, motion, power meters, etc. */
 
/* Power Meters */
.power .icon {color: #D7A22A;} /* Although this says icon, by default this is the text in the center of the power meter tile. */
.power .fa {color: #D7A22A;} /* This will change the color of the Font Awesome icon (lightning bolt) for your power meters. */
.power.inactive {background-color:green;} /* This will set the background color of any Active power meter to the color specified. */
.power[data-value='0W'] {background-color: white;} /* This will set the background color of any power meter that has a data value of 0W (inactive) to the color specified. */
 
/* Energy Meters */
.tile.energy {background-color: white;} /* This will set the background color for all energy meter tiles to the specified color. */
.energy .icon {color: #D7A22A;} /* Although this says icon, by default this is the text in the center of the energy meter tile. */
.energy .fa {color: #D7A22A;} /* This will change the color of the Font Awesome icon (double lightning bolt) for your energy meter tiles. */
 
/* Other Dashboards */
.tile.dashboard {background-color: white;} /* This will change the background color for other Linked Dashboards. */
.tile.dashboard .fa {color: black;} /* This will change the Font Awesome icon color for other Linked Dashboards. */
 
/* Routines */
.hello-home .icon {color: #006778;} /* This will change the background color for Routines (formerly called Hello-Home phrases). */
.hello-home .fa {color: #006778;} /* This will change the icon color for Routines. */
 
/* Link */
.tile.link {background-color: white;} /* This will change the background color for external weblinks. */
.link .icon {color: #32cd32;} /* This will change the icon color for external weblinks. */
 
/* Refresh */
.tile.refresh {background-color: black;} /* This will change the background color for the Refresh tile. */
.refresh .icon {color: #32cd32;} /* This will change the icon color for the Refresh tile. */
.refresh .fa {color: #32cd32;} /* This will change the Font Awesome icon color for the Refresh tile. */
 
/* Clock */
.tile.clock {background-color: black;} /* This will change the background color for the Clock tile. */
.clock .icon {color: #32cd32;} /* This will change the icon color for the Clock tile. */
 
/* History */
.tile.history {background-color: Black;} /* This will change the background color for the Event History tile. */
.history .icon {color: #32cd32;} /* This will change the icon color for the Event History tile. */
 
/* Weather - Basic. For more advanced weather control, please scroll down. */
.tile.weather {background-color: white;} /* This will change the background color for a Smartweather Tile. */
.weather .icon {color: #D7A22A;} /* This will change the icon color for a Smartweather Tile. */
.weather .fa {color: #D7A22A;} /* This will change the Font Awesome icon color for a Smartweather Tile. This includes things like the Umbrella. */
 
/* Camera */
.tile.camera {background-color: black;} /* This will change the background color for Camera tiles. Note that this is NOT for video cameras, but for cameras that can take a still photo when the tile is pressed. */
.camera .icon {color: #32cd32;} /* This will change the icon color for Camera tiles. */
 
/* Temperature */
.tile.temperature {background-color: black;} /* This will change the icon color for Temperature sensor tiles. Further down is a guide for changing the color of the text based on the data value (temperature display). */
 
/* Smart Home Monitor */
.tile.alarm {background-color: white;} /* This will change the background color for Smart Home Monitor. */
.alarm[data-status="away"] .icon i.active:before {color: #FF0000;}     /* This will change the icon color for Armed (Away) mode. */
.alarm[data-status="stay"] .icon i.active:before {color: blue;}        /* This will change the icon color for Armed (Stay) mode. */
.alarm[data-status="off"] .icon i.inactive:before {color: #32CD32;}    /* This will change the icon color for Disarmed mode. */
 
/* Contact Sensors */
.tile.contact {background-color: white;} /* This will change the background color for all Contact Sensor tiles (Open/Close Door and Window Sensors). */
.contact .icon i.active:before {color: #000000;} /* This will change the icon color for Active (Open) Contact Sensor tiles. */
.contact .icon i.inactive:before {color: #9F792C;} /* This will change the icon color for Inactive (Closed) Contact Sensor tiles. */
 
/* Motion Sensors */
.tile.motion {background-color: white;} /* This will change the background color for Motion Sensor tiles. */
.motion .icon i.active:before {color: #006778;} /* This will change the icon color for Active (Motion Active) Motion Sensor tiles. */
.motion .icon i.inactive:before {color: #9F792C;} /* This will change the icon color for Inactive (Motion Inactive) Motion Sensor tiles. */
 
/* Accelerometers */
.tile.acceleration {background-color: white;} /* This will change the background color for Accelerometer (Vibration) sensor tiles. */
.acceleration .icon i.active:before {color: #006778;} /* This will change the icon color for Active (Vibration detected) Accelerometer sensor tiles. */
.acceleration .icon i.inactive:before {color: #9F792C;} /* This will change the icon color for Inactive (Vibration not detected) Accelerometer sensor tiles. */
 
/* Lights */
.tile.light {background-color: black;} /* This will change the background color for Light tiles. */
.light .icon i.active:before {color: #32CD32;} /* This will change the icon color for Active (On) Light tiles. */
.light .icon i.inactive:before {color: #FFFFFF;} /* This will change the icon color for Inactive (Off) Light tiles. */
 
/* Switches */
.tile.switch {background-color: black;} /* This will change the background color for Switch tiles. */
.switch .icon i.active:before {color: #32cd32;} /* This will change the icon color for Active (On) Switch tiles. */
.switch .icon i.inactive:before {color: #000000;} /* This will change the icon color for Inactive (Off) Switch tiles. */
 
/* Dimmable Lights */
.tile.dimmerLight {background-color: black;} /* This will change the background color for Dimmable Light tiles. */
.dimmerLight .icon i.active:before {color: #32cd32;} /* This will change the icon color for Active (On) Dimmable Light tiles. */
.dimmerLight .icon i.inactive:before {color: #000000;} /* This will change the icon color for Inactive (Off) Dimmable Light tiles. */

/* Water Sensors */
.tile.water {background-color: white;} /* This will change the background color for Water tiles. */
.water .icon i.active:before {color: #006778;} /* This will change the icon color for Active (Wet) Water tiles. */
.water .icon i.inactive:before {color: #9F792C;} /* This will change the icon color for Inactive (Dry) Water tiles. */
 
/* Locks */
.tile.lock {background-color: white;} /* This will change the background color for Lock tiles. */
.lock .icon i.active:before {color: #006778;} /* This will change the icon color for Active (Locked) Lock tiles. */
.lock .icon i.inactive:before {color: #9F792C;} /* This will change the icon color for Inactive (Unlocked) Lock tiles. */
 
/* Presence Sensors */
.tile.presence {background-color: white;} /* This will change the background color for Presence tiles. */
.presence .icon i.active:before {content : url(http://cdn.device-icons.smartthings.com/People/people1-icn@2x.png); position: relative; top: 27px; left: -18px;} /* This will change the icon to a custom icon for when Presence is detected. This icon is from SmartThings. */
.presence .icon i.inactive:before {color: #9F792C; content : " "; color: gray;} /* This will change the icon to a custom Font Awesome icon and to the color specified when Presence is not detected (Away). */
 
/* Battery Tiles - Basic. For more battery customization, please scroll down. */
.tile.battery {background-color: blue;} /* This will change the background color for Battery Tiles. */
.battery .icon {color: FF0000;} /* This will change the color of the icon (text representation of battery percentage) for Battery Tiles. This can also be configured to change color based on the data value (See below example for Temperature Sensor). */
.batt svg {
width: 16px;
height: 16px;
transform: rotate(270deg);} /* This will change the width, height, and orientation of the battery icon in the bottom left corner of a Battery Tile. */
.batt path {fill: white;} /* This will change the color of the battery fill (small bars representing battery level). */
 
/* Temperature Sensor Text Color Based on Data Value (Temperature Reading) */
.temperature[data-value='140°'] .icon {color: #FF0040}
.temperature[data-value='139°'] .icon {color: #FF0038}
.temperature[data-value='138°'] .icon {color: #FF0030}
.temperature[data-value='137°'] .icon {color: #FF0028}
.temperature[data-value='136°'] .icon {color: #FF0020}
.temperature[data-value='135°'] .icon {color: #FF0018}
.temperature[data-value='134°'] .icon {color: #FF0010}
.temperature[data-value='133°'] .icon {color: #FF0008}
.temperature[data-value='132°'] .icon {color: #FF0000}
.temperature[data-value='131°'] .icon {color: #FF0500}
.temperature[data-value='130°'] .icon {color: #FF0A00}
.temperature[data-value='129°'] .icon {color: #FF0F00}
.temperature[data-value='128°'] .icon {color: #FF1400}
.temperature[data-value='127°'] .icon {color: #FF1900}
.temperature[data-value='126°'] .icon {color: #FF1E00}
.temperature[data-value='125°'] .icon {color: #FF2300}
.temperature[data-value='124°'] .icon {color: #FF2800}
.temperature[data-value='123°'] .icon {color: #FF2D00}
.temperature[data-value='122°'] .icon {color: #FF3200}
.temperature[data-value='121°'] .icon {color: #FF3700}
.temperature[data-value='120°'] .icon {color: #FF3C00}
.temperature[data-value='119°'] .icon {color: #FF4100}
.temperature[data-value='118°'] .icon {color: #FF4600}
.temperature[data-value='117°'] .icon {color: #FF4B00}
.temperature[data-value='116°'] .icon {color: #FF5000}
.temperature[data-value='115°'] .icon {color: #FF5500}
.temperature[data-value='114°'] .icon {color: #FF5A00}
.temperature[data-value='113°'] .icon {color: #FF5F00}
.temperature[data-value='112°'] .icon {color: #FF6400}
.temperature[data-value='111°'] .icon {color: #FF6900}
.temperature[data-value='110°'] .icon {color: #FF6E00}
.temperature[data-value='109°'] .icon {color: #FF7300}
.temperature[data-value='108°'] .icon {color: #FF7800}
.temperature[data-value='107°'] .icon {color: #FF7D00}
.temperature[data-value='106°'] .icon {color: #FF8200}
.temperature[data-value='105°'] .icon {color: #FF8700}
.temperature[data-value='104°'] .icon {color: #FF8C00}
.temperature[data-value='103°'] .icon {color: #FF9100}
.temperature[data-value='102°'] .icon {color: #FF9600}
.temperature[data-value='101°'] .icon {color: #FF9B00}
.temperature[data-value='100°'] .icon {color: #FFA000}
.temperature[data-value='99°'] .icon {color: #FFA500}
.temperature[data-value='98°'] .icon {color: #FFAA00}
.temperature[data-value='97°'] .icon {color: #FFAF00}
.temperature[data-value='96°'] .icon {color: #FFB400}
.temperature[data-value='95°'] .icon {color: #FFB900}
.temperature[data-value='94°'] .icon {color: #FFBE00}
.temperature[data-value='93°'] .icon {color: #FFC300}
.temperature[data-value='92°'] .icon {color: #FFC800}
.temperature[data-value='91°'] .icon {color: #FFCD00}
.temperature[data-value='90°'] .icon {color: #FFD200}
.temperature[data-value='89°'] .icon {color: #FFD700}
.temperature[data-value='88°'] .icon {color: #FFDC00}
.temperature[data-value='87°'] .icon {color: #FFE100}
.temperature[data-value='86°'] .icon {color: #FFE600}
.temperature[data-value='85°'] .icon {color: #FFEB00}
.temperature[data-value='84°'] .icon {color: #FFF000}
.temperature[data-value='83°'] .icon {color: #FFF500}
.temperature[data-value='82°'] .icon {color: #FFFA00}
.temperature[data-value='81°'] .icon {color: #FEFC00}
.temperature[data-value='80°'] .icon {color: #FDFF00}
.temperature[data-value='79°'] .icon {color: #EAFF00}
.temperature[data-value='78°'] .icon {color: #D7FF00}
.temperature[data-value='77°'] .icon {color: #C3FF00}
.temperature[data-value='76°'] .icon {color: #B0FF00}
.temperature[data-value='75°'] .icon {color: #9DFF00}
.temperature[data-value='74°'] .icon {color: #8AFF00}
.temperature[data-value='73°'] .icon {color: #77FF00}
.temperature[data-value='72°'] .icon {color: #65FF00}
.temperature[data-value='71°'] .icon {color: #51FF00}
.temperature[data-value='70°'] .icon {color: #3EFF00}
.temperature[data-value='69°'] .icon {color: #2AFF00}
.temperature[data-value='68°'] .icon {color: #17FF00}
.temperature[data-value='67°'] .icon {color: #0BFF08}
.temperature[data-value='66°'] .icon {color: #00FF10}
.temperature[data-value='65°'] .icon {color: #00FF23}
.temperature[data-value='64°'] .icon {color: #00FF36}
.temperature[data-value='63°'] .icon {color: #00FF49}
.temperature[data-value='62°'] .icon {color: #00FF5C}
.temperature[data-value='61°'] .icon {color: #00FF6F}
.temperature[data-value='60°'] .icon {color: #00FF83}
.temperature[data-value='59°'] .icon {color: #00FF95}
.temperature[data-value='58°'] .icon {color: #00FFA8}
.temperature[data-value='57°'] .icon {color: #00FFBC}
.temperature[data-value='56°'] .icon {color: #00FFD0}
.temperature[data-value='55°'] .icon {color: #00FFE2}
.temperature[data-value='54°'] .icon {color: #00FFF4}
.temperature[data-value='53°'] .icon {color: #00F1F9}
.temperature[data-value='52°'] .icon {color: #00E4FF}
.temperature[data-value='51°'] .icon {color: #00DCFF}
.temperature[data-value='50°'] .icon {color: #00D4FF}
.temperature[data-value='49°'] .icon {color: #00CCFF}
.temperature[data-value='48°'] .icon {color: #00C4FF}
.temperature[data-value='47°'] .icon {color: #00BCFF}
.temperature[data-value='46°'] .icon {color: #00B4FF}
.temperature[data-value='45°'] .icon {color: #00ACFF}
.temperature[data-value='44°'] .icon {color: #00A4FF}
.temperature[data-value='43°'] .icon {color: #009CFF}
.temperature[data-value='42°'] .icon {color: #0094FF}
.temperature[data-value='41°'] .icon {color: #008CFF}
.temperature[data-value='40°'] .icon {color: #0084FF}
.temperature[data-value='39°'] .icon {color: #007CFF}
.temperature[data-value='38°'] .icon {color: #0074FF}
.temperature[data-value='37°'] .icon {color: #006CFF}
.temperature[data-value='36°'] .icon {color: #0064FF}
.temperature[data-value='35°'] .icon {color: #005CFF}
.temperature[data-value='34°'] .icon {color: #0054FF}
.temperature[data-value='33°'] .icon {color: #004CFF}
.temperature[data-value='32°'] .icon {color: #0044FF}
.temperature[data-value='31°'] .icon {color: #003BFF}
.temperature[data-value='30°'] .icon {color: #0032FF}
.temperature[data-value='29°'] .icon {color: #002AFF}
.temperature[data-value='28°'] .icon {color: #0022FF}
.temperature[data-value='27°'] .icon {color: #001AFF}
.temperature[data-value='26°'] .icon {color: #0012FF}
.temperature[data-value='25°'] .icon {color: #000AFF}
.temperature[data-value='24°'] .icon {color: #0002FF}
.temperature[data-value='23°'] .icon {color: #0001FF}
.temperature[data-value='22°'] .icon {color: #0000FF}
.temperature[data-value='21°'] .icon {color: #0000FF}
.temperature[data-value='20°'] .icon {color: #0100FF}
.temperature[data-value='19°'] .icon {color: #0100FF}
.temperature[data-value='18°'] .icon {color: #0200FF}
.temperature[data-value='17°'] .icon {color: #0200FF}
.temperature[data-value='16°'] .icon {color: #0300FF}
.temperature[data-value='15°'] .icon {color: #0300FF}
.temperature[data-value='14°'] .icon {color: #0400FF}
.temperature[data-value='13°'] .icon {color: #0400FF}
.temperature[data-value='12°'] .icon {color: #0500FF}
 
/* SLIDERS */
.music .ui-slider.ui-mini{padding:0 10px 10px 40px}
.ui-slider.ui-mini{padding:0 10px 10px 12px}
.ui-page-theme-a .tile.active .ui-slider-track .ui-btn-active {background-color: white} /* active left slider bar */
.ui-page-theme-a .ui-slider-track .ui-btn-active {background-color:#666666} /* inactive left slider bar */
.ui-slider-handle.ui-btn.ui-shadow {background-color: #666666} /* inactive slider button */
.tile.active .ui-slider-handle.ui-btn.ui-shadow {background-color: white} /* active slider button */
.ui-page-theme-a .ui-bar-inherit {background-color: #666666} /* inactive right slider bar */
.ui-page-theme-a .tile.active .ui-bar-inherit {background-color: white}
 
/* ICON OPACITY */
.fa-toggle-off {opacity: 1!important} /* Icons no longer transparent */
.fa-toggle-on {opacity: 1!important} /* Icons no longer transparent */
.fa-shield {opacity: 1!important} /* Icons no longer transparent */
.fa-expand {opacity: 1!important} /* Icons no longer transparent */
.fa-compress {opacity: 1!important} /* Icons no longer transparent */
.fa-lightbulb-o {opacity: 1!important} /* Icons no longer transparent */
.fa-tint {opacity: 1!important} /* Icons no longer transparent */
.fa-exchange {opacity: 1!important} /* Icons no longer transparent */
 
/* WEATHER */
.weather[data-weather='mostlycloudy'] {background-color: #D3D3D3} /* Changes the tile background color based on mostly-cloudy conditions */
.weather[data-weather='nt_partlycloudy'] {background-color: #D3D3D3} /* Changes the tile background color based on partly-cloudy conditions */
.weather[data-weather='cloudy'] {background-color: #D3D3D3} /* Changes the tile background color based on cloudy conditions */
.weather[data-weather='fog'] {background-color: #D3D3D3} /* Changes the tile background color based on fog conditions */
.weather[data-weather='rain'] {background-color: #6666CE} /* Changes the tile background color based on rain conditions */
.weather[data-weather='clear'] {background-color: #FFD700} /* Changes the tile background color based on clear conditions */
.weather[data-weather='sunny'] {background-color: #FFD700} /* Changes the tile background color based on sunny conditions */
.weather[data-weather='snow'] {background-color: #FFFFFF} /* Changes the tile background color based on snow conditions */
 
/* Battery - Changes battery value color based on the percentage and change footer icon to custom icon based on URL */
.battery[data-value^='0'] .icon {color: #FF0040} /* Changes battery value color based on percentage */
.battery[data-value^='0'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)} /* Changes battery icon in footer based on percentage */
.battery[data-value^='1'] .icon {color: #FF0040} /* Changes battery value color based on percentage */
.battery[data-value^='1'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='2'] .icon {color: #FF0040} /* Changes battery value color based on percentage */
.battery[data-value^='2'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='3'] .icon {color: #FFD700} /* Changes battery value color based on percentage */
.battery[data-value^='3'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='4'] .icon {color: #FFD700} /* Changes battery value color based on percentage */
.battery[data-value^='4'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='5'] .icon {color: #FFD700} /* Changes battery value color based on percentage */
.battery[data-value^='5'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='6'] .icon {color: #32CD32} /* Changes battery value color based on percentage */
.battery[data-value^='6'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='7'] .icon {color: #32CD32} /* Changes battery value color based on percentage */
.battery[data-value^='7'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='8'] .icon {color: #32CD32} /* Changes battery value color based on percentage */
.battery[data-value^='8'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='9'] .icon {color: #32CD32} /* Changes battery value color based on percentage */
.battery[data-value^='9'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
.battery[data-value^='10'] .icon {color: #32CD32} /* Changes battery value color based on percentage */
.battery[data-value^='10'] .footer {width: 40px;height: 20px;transform: rotate(0deg);padding:105px 0px 0px 0px;content : url(http://www.yourdomainhere)}} /* Changes battery icon in footer based on percentage */
 
/* Battery - Changes battery icon to Font Awesome battery icons and changes color and fill amount based on percentage */
.battery[data-value^='0'] .batt:after {content:""; color: #FA0000}
.battery[data-value^='0'] .batt svg {display: none;}
.battery[data-value^='1'] .batt:after {content:""; color: #FB3300}
.battery[data-value^='1'] .batt svg {display: none;}
.battery[data-value^='2'] .batt:after {content:""; color: #FC6600}
.battery[data-value^='2'] .batt svg {display: none;}
.battery[data-value^='3'] .batt:after {content:""; color: #FD9900}
.battery[data-value^='3'] .batt svg {display: none;}
.battery[data-value^='4'] .batt:after {content:""; color: #FECC00}
.battery[data-value^='4'] .batt svg {display: none;}
.battery[data-value^='5'] .batt:after {content:""; color: #FFFF00}
.battery[data-value^='5'] .batt svg {display: none;}
.battery[data-value^='6'] .batt:after {content:""; color: #CCFF00}
.battery[data-value^='6'] .batt svg {display: none;}
.battery[data-value^='7'] .batt:after {content:""; color: #99FF00}
.battery[data-value^='7'] .batt svg {display: none;}
.battery[data-value^='8'] .batt:after {content:""; color: #66FF00}
.battery[data-value^='8'] .batt svg {display: none;}
.battery[data-value^='9'] .batt:after {content:""; color: #33FF00}
.battery[data-value^='9'] .batt svg {display: none;}
.battery[data-value^='10'] .batt:after {content:""; color: #00FF00}
.battery[data-value^='10'] .batt svg {display: none;}
 
/* Specific Device Tile Manipulation */
/* Change the tile type to suit the needs based on what device you are using. Then you will add in the device ID between the 2 single quotes (replacing all of the X's). */
/* This example will show using Font Awesome icons. */
 
/* My Light Switch */
.tile.switch[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] {background-color: #464646} /* This will change the background color for the specific switch tile whose device ID matches the data-device you enter. */
.tile.switch[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] .icon i.active:before {content: " ";} /* This will change the Active Switch to the Font Awesome icon selected. A color tag can also be added. */
.tile.switch[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] .icon i.inactive:before {content: " ";} /* This will change the Inactive Switch to the Font Awesome icon selected. A color tag can also be added. */
 
/* This example will show using Custom Icon URLs. */
 
/* My Dimmable Light */
.tile.dimmerLight[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] {background-color: white;} /* This will change the background color for the specific Dimmable Light tile whose device ID matches the data-device you enter. */
.tile.dimmerLight[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] .icon i.active:before {content: url(http://cdn.device-icons.smartthings.com/Lighting/light11-icn@2x.png);position: relative; left: -20px; top: 27px;} /* This will change the Active (On) Icon to match the URL and also adjust its location to be centered. */
.tile.dimmerLight[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] .icon i.inactive:before {{content: url(http://cdn.device-icons.smartthings.com/Lighting/light20-icn@2x.png);position: relative; left: -20px; top: 27px;} /* This will change the Inactive (Off) Icon to match the URL and also adjust its location to be centered. */
 
/* This example will show using a Custom Icon URL for Active and using the default icon for Inactive. */
 
/* Vacuum Cleaner */
.tile.switch[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] {background-color: #464646} /* This will change the background color for the specific Switch tile whose device ID matches the data-device you enter. */
.tile.switch[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] .icon i.active:before {content: url(http://cdn.device-icons.smartthings.com/Appliances/appliances13-icn@2x.png);} /* This will change the Active (On) Switch icon to match the URL image. */
.tile.switch[data-device='xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'] .icon i.inactive:before {content: " ";} /* This will change the Inactive (Off) Switch icon to match the Font Awesome icon. A color tag may be added. */
 
 
/* END CUSTOM CSS */
