
(function () {
    "use strict";

    document.addEventListener( 'deviceready', onDeviceReady.bind( this ), false );

    function onDeviceReady() {

        document.addEventListener( 'pause', onPause.bind( this ), false );
        document.addEventListener( 'resume', onResume.bind( this ), false );
        document.getElementById("BtnDevice").addEventListener("click", DeviceAbout());

    };

    function onPause() {

    };

    function onResume() {

    };
    function DeviceAbout() {

        alert("Model: " + device.model + "\n"
            + "Platform: " + device.platform + "\n"
            + "versiyon: " + device.version + "\n"
            + "UUID: " + device.uuid + "\n"
            + "Cordova Versiyon: " + device.cordova);
    };
} )();