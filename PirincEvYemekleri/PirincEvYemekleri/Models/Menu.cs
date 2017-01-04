using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirincEvYemekleri.Models
{
    class Menu
    {
        public List<AnaYemek> name { get; set; }
        public List<Salata> salatalar { get; set; }
        public List<Tatli> tatlilar { get; set; }
    }
}
