using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    class Tofas : Otomobil
    {
        public Tofas()
        {
            seri = "Serce";
            model = "Murat 131";
            motorGucu = 65;
            motorHacmi = 1400;
        }
        public override string çalirtir()
        {
            return "tır tır tır";
        }
    }
}
