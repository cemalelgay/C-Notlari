using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kentkart_OOP
{
    public class ÖgretmenKart : Kart
    {
        public override void Okut()
        {
            MessageBox.Show("2 ₺ aldındı. Kalan Bakiye : " + (bakiye - 2));
            bakiye -= 2;
        }
        public override string ToString()
        {
            return this.kartID + "\t" + this.bakiye + "\t" + "-" + "\t" + this.kartTuru;
        }
    }
}
