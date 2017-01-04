using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    class Ogrenci : IKisiBilgileri
    { private string _ad;
        public string ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }
        private string _soyad;
        public string soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }
        private string _telefon;
        public string telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string BilgiGoster()
        {
            return string.Format("Ad: {0} \t Soyad: {1} \t Telefon: {2}",ad,soyad,telefon);
        }


    }
}
