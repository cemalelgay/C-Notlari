using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KütüphaneOtomasyonuCemal.Class
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAd { get; set; }
        public int KitapNo { get; set; }
        public string Konusu { get; set; }
        public int RafNo { get; set; }
        public int SayfaSayisi { get; set; }
        public string KitapKonusu { get; set; }
    }
}