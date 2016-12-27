using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
   public abstract class Otomobil // Otomobili class'ından nesne türetme.
    {
        public string seri { get; set; }
        public string model { get; set; }
        public int motorGucu { get; set; }
        public int motorHacmi { get; set; }

        public override string ToString()
        {
            return string.Format("Seri: {0} Model: {1} Motor Gücü: {2} Motor Hacmi {3}", seri, model, motorGucu, motorHacmi);
        }

        public abstract string çalirtir();
     
    }
}
