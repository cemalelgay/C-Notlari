using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    class Honda : Otomobil
    {
        public Honda()
        {
            seri = "Vtec";
            model = "S2000";
            motorGucu = 250;
            motorHacmi = 2000;
        }
        public override string çalirtir()
        {
            return "Vututututututututu";
        }
    }
}
