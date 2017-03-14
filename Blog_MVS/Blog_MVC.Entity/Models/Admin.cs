using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC.Entity.Models
{
    public class Admin : Base
    {
        public int AdminID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
