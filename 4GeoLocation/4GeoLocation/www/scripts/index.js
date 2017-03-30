
(function () {
    "use strict";

    document.addEventListener('deviceready', onDeviceReady, false);

    function onDeviceReady() {

        document.addEventListener('pause', onPause, false);
        document.addEventListener('resume', onResume, false);
        document.getElementById("getPosition").addEventListener("click", getPosition)
    };

    function onPause() {

    };

    function onResume() {

    };
    function getPosition() {

        var options = {
            enableHighAccuracy: true, // En iyi ölçüm için.
            maximumAge: 3000,          // Time vermemizi sağlıyor. Bi önceki ölçümden geçen zaman.
        }
        var watchID = navigator.geolocation.getCurrentPosition(onSuccess, onerror, options);

        function onSuccess(position) {
            document.getElementById("sonuc").innerHTML =
                "Latitude = " + position.coords.latitude + "<br/>" + //enlem
                 "Longitude = " + position.coords.longitude + "<br/>" + //boylam
                  "Accuracy = " + position.coords.accuracy + "<br/>"  //doğruluk
        }
        function onError() {
            alert(error.message);
        }
    }
})();