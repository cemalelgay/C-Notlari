
(function () {
    "use strict";

    document.addEventListener('deviceready', onDeviceReady, false);

    function onDeviceReady() {

        document.addEventListener('pause', onPause, false);
        document.addEventListener('resume', onResume, false);
        document.getElementById("btn").addEventListener("click", BtnClick);
        document.getElementById("btnOnay").addEventListener("click", BtnOnayClick);
        document.getElementById("btnBeep").addEventListener("click", BtnBeepClick);
        document.getElementById("btnInput").addEventListener("click", BtnInputClick);
    };

    function onPause() {

    };

    function onResume() {
        alert("Neden Geri Geldin...!");
    };

    function BtnClick() {
        //alert("Merhaba");

        var mesaj = "Merhaba Dünya";
        var baslik = "Uyarı Mesajı";
        var btnName = "Tamam";

        navigator.notification.alert(mesaj, alertCallBack, baslik, btnName)
        function alertCallBack() {

        }
    }
    function BtnOnayClick() {
        //alert("Merhaba");

        var mesaj = "Merhaba Dünya";
        var baslik = "Uyarı Mesajı";
        var buttonLabels = "Yes,No";

        navigator.notification.confirm(mesaj, confimCallBack, baslik, buttonLabels);
        function confimCallBack(btn) {
            alert("Basılan Buton:" + btn);
        }
    }
    function BtnBeepClick() {
        var time = 2; //Kaç kere
        navigator.notification.beep(time);
    }
    function BtnInputClick() {
        var mesaj = "Adınız Nedir ?";
        var title = "Tanışalım mı ?";
        var buttons = ["Evet", "Hayır"];
        var defText = "...";
        navigator.notification.prompt(mesaj, promptCallBack, title, buttons, defText);

        function promptCallBack(result) {
            if (result.buttonIndex == 1) {
                alert("Merhaba " + result.input1);
            }
            else {
                alert("Sevgilim Varrrr")
            }
        }
    }
})();