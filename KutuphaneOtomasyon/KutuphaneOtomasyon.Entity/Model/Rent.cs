using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Entity.Model
{
    public class Rent
    {
        public int RentID { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        //Mapping

        public VMBook Book { get; set; }
        public User User { get; set; }
    }
}
