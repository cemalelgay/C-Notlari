using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class Haber
    {
        public string baslik { get; set; }
        public string haber { get; set; }

        public string link { get; set; }

        public Haber(string baslik , string haber)
        {
            this.baslik = baslik;
            this.link = link;
        }

        public override string ToString()
        {
            return this.baslik;
        }
    }
}
