using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class Kesinti
    {
        public string baslik { get; set; }

        public string bilgi { get; set; }

        public Kesinti(string baslik, string bilgi)
        {
            this.baslik = baslik;
            this.bilgi = bilgi;

        }

        public override string ToString()
        {
            return this.baslik;
        }
    }
}
