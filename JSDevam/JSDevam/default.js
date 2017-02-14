var kisiListesi = [];
var kisiEkle = function ()
{
    var kisi = {};
    kisi.Ad = Get('txtAdSoyad').value;
    if (kisi.Ad == "")  
        alert("Uygun formatta isim giriniz")    
    else   
        kisi.email = get('txtEmail').value;
    
    if (kisi.email == "")   
        alert("emaili dogru formatta giriniz")
    kisi.bilgiGetir = function()
    {
        return kisi.Ad + " " + kisi.email;
    }
    kisiListesi.push(kisi);
    Get('kisiler').innerHTML += kisi.bilgiGetir() + "</br>";
}
function Get(elementID)
{
    return document.getElementById(elementID);
}