using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBCemal.Entity.Model.ViewModel
{
    public class VMFilm
    {
        public int FilmID { get; set; }
        public string FilmAdi { get; set; }
        public string YonetmenAdi { get; set; }
        public string TurAdi { get; set; }
        public double Puan { get; set; }
    }
}
