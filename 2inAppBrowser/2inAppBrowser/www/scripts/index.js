
(function () {
    "use strict";

    document.addEventListener( 'deviceready', onDeviceReady, false );

    function onDeviceReady() {

        document.addEventListener( 'pause', onPause, false );
        document.addEventListener('resume', onResume, false);
        var ref = window.open('http://google.com', '_blank', 'location=yes');
        

    };

    function onPause() {

    };

    function onResume() {

    };
} )();