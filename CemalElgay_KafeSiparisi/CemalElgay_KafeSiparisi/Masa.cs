using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemalElgay_KafeSiparisi
{
    class Masa
    {
        public int masaNo { get; set; }
        public double tutar { get; set; }

        public List<Icecek> Icecekler { get; set; }
        public List<Yemek> Yemekler { get; set; }
    }
}
