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
        public int FilmPuani { get; set; }
        public string TurID { get; set; }
        public string FilmYonetmeni { get; set; }
    }
}
