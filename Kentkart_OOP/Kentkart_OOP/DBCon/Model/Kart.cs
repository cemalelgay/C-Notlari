using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms

namespace Kentkart_OOP
{
    public enum YolcuTipi
    {
        Tam,
        Ogrenci,
        Ogretmen,
    };
    public class Kart
    {
        private double _bakiye;
        public double bakiye
        {
            get
            {
                return _bakiye;
            }
            set
            {
                if (value < 0)
                {
                    System.Windows.Forms.MessageBox.Show("Bakiye Yetersiz!");
                }
                else
                {
                    _bakiye = value;
                }
            }
        }

        public int kartID { get; set; }

        public YolcuTipi kartTuru { get; set; }

        public virtual void Okut()
        {
            System.Windows.Forms.MessageBox.Show("Biniş Başarılı! Kalan Bakiye" + (bakiye - 3));
            bakiye -= 3;
        }

        public override string ToString()
        {
            return this.kartID + "\t" + this.bakiye + "\t" + "-" + "\t" + this.kartTuru;
        }
    }
}
