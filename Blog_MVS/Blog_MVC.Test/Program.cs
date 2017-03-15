using Blog_MVC.Entity.DBContext;
using Blog_MVC.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test
            //Admin adm = new Admin();
            //adm.UserName = "cemalelgay";
            //adm.Password = "123";
            //db.Admin.Add(adm);

            //Category cat = new Category();
            //cat.Name = "OOP";
            //db.Category.Add(cat);

            //Post p1 = new Post()
            //{
            //    Title = "Başlık 1",
            //    Contenct = "Buraya içerik gelecek",
            //    PostDate = DateTime.Now,
            //    AdminID = 1,
            //    CategoryID = 1,
            //};
            //Post p2 = new Post()
            //{
            //    Title = "Başlık 2",
            //    Contenct = "Buraya içerik gelecek",
            //    PostDate = DateTime.Now,
            //    AdminID = 1,
            //    CategoryID = 1,
            //};
            //Post p3 = new Post()
            //{
            //    Title = "Başlık 3",
            //    Contenct = "Buraya içerik gelecek",
            //    PostDate = DateTime.Now,
            //    AdminID = 1,
            //    CategoryID = 1,
            //};
            //db.Post.Add(p1);
            //db.Post.Add(p2);
            //db.Post.Add(p3);

            //Tag tag1 = new Tag()
            //{
            //    Name = "Asp.Net NVC",
            //    Posts = new List<Post>()
            //    {
            //        p1,
            //        p2,
            //    }
            //};
            //Tag tag2 = new Tag()
            //{
            //    Name = "C#",
            //    Posts = new List<Post>()
            //    {
            //        p3,
            //    }
            //};

            //db.Tag.Add(tag1);
            //db.Tag.Add(tag2);
            #endregion

            #region BlogDBContext
            //using (BlogDBContext db = new BlogDBContext())
            //{
            //    Post p = new Post();
            //    p.AdminID = 1;
            //    p.CategoryID = 1;
            //    p.Title = "Title1";
            //    p.Contenct = "Content1";
            //    p.PostDate = DateTime.Now;
            //    //p.Tags = new List<Tag>
            //    //{
            //    //    new Tag { Name = "Tag1" },
            //    //    new Tag { Name = "Tag2" }
            //    //};

            //    p.Tags = db.Tag.Where(t => t.Name == "Tag1" || t.Name == "Tag2").ToList();

            //    db.Post.Add(p);

            //    db.SaveChanges();
            //}
            #endregion
            using (BlogDBContext db = new BlogDBContext())
            {
                Post p = new Post();
                p.AdminID = 1;
                p.CategoryID = 1;
                p.Title = "Title2";
                p.Contenct = "Content2";
                p.PostDate = DateTime.Now;
                //p.Tags = new List<Tag>
                //{
                //    new Tag { Name = "Tag1" },
                //    new Tag { Name = "Tag2" }
                //};

                p.Tags = db.Tag.Where(t => t.Name == "Tag1" || t.Name == "Tag2").ToList();

                db.Post.Add(p);

                db.SaveChanges();
            }
        }
    }
}