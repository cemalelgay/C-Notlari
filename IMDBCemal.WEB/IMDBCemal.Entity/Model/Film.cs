using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBCemal.Entity.Model
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmAdı { get; set; }
        public string FilmKonusu { get; set; }
        public DateTime FilmCikisTarihi { get; set; }
        public double FilmPuani { get; set; }
        public int FilmSayisi { get; set; }
        public int TurID { get; set; }
        public int YonetmenlerID { get; set; }
        public Tur Tur { get; set; }
        public Yonetmenler Yonetmenler { get; set; }
    }
}
