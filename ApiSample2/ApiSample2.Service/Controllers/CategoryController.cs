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
    }
}
