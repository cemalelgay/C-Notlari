using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC.Entity.Models
{
    public class Category : Base
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
