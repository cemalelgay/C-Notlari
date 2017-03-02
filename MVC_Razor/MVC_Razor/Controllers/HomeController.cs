using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor.Controllers
{
    public class HomeController : Controller
    {
        //add view - go to view
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Mesaj = "Merhaba Dünya";
            return View();
        }
    }
}