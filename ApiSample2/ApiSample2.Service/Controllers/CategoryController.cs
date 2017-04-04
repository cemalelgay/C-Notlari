using ApiSample2.Service.Models;
using ApiSample2.Service.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiSample2.Service.Controllers
{
    public class CategoryController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        public List<Kategori> Get()
        {
            //fiddler , postman
            //http://localhost:65021/api/Category/
            //http://localhost:65021/api/Category/Get
            List<Kategori> catList = db.Categories.Select(x => new Kategori()
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName
            }).ToList();

            return catList;
        }

        public Kategori Get(int id)
        {
            //http://localhost:65021/api/Category/Get/1
            Kategori cat = db.Categories.Where(c => c.CategoryID == id).Select(c => new Kategori()
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName
            }).FirstOrDefault();

            return cat;
        }
        public void Post(Kategori Kategori)
        {
            Category cat = new Category();
            cat.CategoryName = Kategori.CategoryName;
            db.Categories.Add(cat);
            db.SaveChanges();
        }
        public void Put(Kategori kategori) //Güncelleme
        {
            var cat = db.Categories.FirstOrDefault(c => c.CategoryID == kategori.CategoryID);
            cat.CategoryName = kategori.CategoryName;
            db.SaveChanges();
        }
        public void Delete(int id) //Silme
        {
            var cat = db.Categories.FirstOrDefault(c => c.CategoryID == id);
            db.Categories.Remove(cat);
            db.SaveChanges();
        }
    }
}
