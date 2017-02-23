using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Entity.Model.ViewModel
{
    public class VMBook
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookSubject { get; set; }
        public int PageCount { get; set; }
        public string WriterName { get; set; }
        public int ShelfNumber { get; set; }
        public bool IsRented { get; set; }

        //Mapping

    }
}
