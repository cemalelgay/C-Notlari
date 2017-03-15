using Blog_MVC.Entity.DBContext;
using Blog_MVC.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC.DAL.Repos
{
    class CategoryRepo
    {
        public static List<Category> GetAll()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Category.ToList();
            }
        }
        public static Category Get(int categoryID)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Category.Find(categoryID);
            }
        }
    }
}