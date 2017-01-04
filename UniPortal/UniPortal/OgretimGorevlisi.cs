using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    class OgretimGorevlisi : IKisiBilgileri, ICalisanBilgileri
    {
        private string _ad;
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
        private string _bolum;
        public string bolumu
        {
            get
            {
                return _bolum;
            }

            set
            {
                _bolum = value;
            }
        }
        private string _gorevi;
        public string gorevi
        {
            get
            {
                return _gorevi;
            }

            set
            {
                _gorevi = value;
            }
        }

        public string BilgiGoster()
        {
            return string.Format("Ad: {0} \t Soyad: {1} \t Telefon: {2} \t Bölüm: {3} \t Görev: {4}", ad, soyad, telefon,bolumu,gorevi);
        }
    }
}
