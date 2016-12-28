using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kentkart_OOP
{
    class ÖgrenciKart : Kart
    {
        public ÖgrenciKart()
        {

        }

        public string okulAdi { get; set; }

        public override void Okut()
        {
            MessageBox.Show("1 ₺ aldındı. Kalan Bakiye : " + (bakiye - 1));
            bakiye -= 1;
        }
        public override string ToString()
        {
            return this.kartID + "\t" + this.bakiye + "\t " + this.okulAdi + "\t" + this.kartTuru;
        }
    }
}
