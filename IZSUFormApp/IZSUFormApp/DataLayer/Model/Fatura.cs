using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSUFormApp.DataLayer.Model
{
    public class Fatura
    {
        public int FaturaID { get; set; }
        public int AboneID { get; set; }
        public decimal OdemeTutari { get; set; }
        public int OncekiSayac { get; set; }
        public int GuncelSayac { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public bool Tahsilat { get; set; }

        public Abone Abone { get; set; }
    }
}
