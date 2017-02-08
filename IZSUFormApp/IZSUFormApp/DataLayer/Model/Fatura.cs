using IZSUFormApp.DataLayer.DBCon;
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
        public double OdemeHesapla()
        {
            int _aboneTuruID;
            double result = 0;

            using (IzsuDBContext context = new IzsuDBContext())
            {
                //result = context.Abone.Where(a => a.AboneID == AboneID).Select(a => a.AboneTuru.AboneTuruAd).ToString();
                //result = context.Abone.FirstOrDefault(a => a.AboneID == AboneID).AboneTuruID;
                _aboneTuruID = context.Abone.FirstOrDefault(a => a.AboneID == AboneID).AboneTuruID;
            }
            if (_aboneTuruID == 1) //Hususi
            {
                result = (GuncelSayac - OncekiSayac) * 0.3;
            }
            else if (_aboneTuruID ==2) //Şirket / Kurum
            {
                result = (GuncelSayac - OncekiSayac) * 0.5;
            }
            return result;
        }
    }
}
