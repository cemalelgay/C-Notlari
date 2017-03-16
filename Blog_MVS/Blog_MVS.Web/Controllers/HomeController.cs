using Blog_MVC.DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(PostRepo.GetAll());
        }
        public ActionResult PostDetail(int id)
        {
            return View(PostRepo.Get(id));
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}