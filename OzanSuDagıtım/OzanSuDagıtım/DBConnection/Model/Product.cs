using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzanSuDagıtım.DBConnection.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<double> ProductPrice { get; set; }
        public double ProductSize { get; set; }
    }
}
