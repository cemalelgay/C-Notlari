using Blog_MVC.Entity.DBContext;
using Blog_MVC.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC.DAL.Repos
{
    public class CategoryRepo
    {
        public static List<Category> GetAll()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Category.ToList();
            }
        }
        public static Category Get(string categoryName)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Category.FirstOrDefault(c => c.Name == categoryName);
            }
        }
        public static void Add(Category cat)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                db.Category.Add(cat);
                db.SaveChanges();
            }
        }
    }
}