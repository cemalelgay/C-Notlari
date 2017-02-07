using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSUFormApp.DataLayer.Model
{
    public class Abone
    {
        public int AboneID { get; set; }
        public int AboneNo { get; set; }
        public string AboneAdSoyad { get; set; }
        public int AboneTuruID { get; set; }

        public AboneTuru AboneTuru { get; set; }
    }
}
