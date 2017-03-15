using Blog_MVC.Entity.DBContext;
using Blog_MVC.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC.DAL.Repos
{
    public class PostRepo
    {
        public static List<Post> GetAll()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Post.ToList();
            }
        }
        public static void Add(Post post)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                foreach (var itemTag in post.Tags)
                {
                    var result = db.Tag.Include("Posts").FirstOrDefault(t => t.Name == itemTag.Name);

                    if (result != null)
                    {
                        post.Tags = null; // Bunu yapmassak aynı isimde taglar ekliyor.
                        result.Posts.Add(post);
                    }
                    else
                    {
                        itemTag.Posts = new List<Post>() { post }; //Otomatik olarak postu yaratır.
                        db.Tag.Add(itemTag);
                    }
                }

                db.SaveChanges();
            }
        }
        public static Post Get(int postID)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Post.Find(postID);
            }
        }
    }
}