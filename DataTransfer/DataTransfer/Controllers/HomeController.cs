using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        //ActionResult Controller ile View Arasındaki iletişimi sağlayan methoddur. Olmak zorundadır.
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Messages1"] = "Bu bir ViewData mesajıdır.";
            ViewBag.Messages2 = "Bu bir ViewBag mesajıdır.";
            TempData["Messages3"] = "Bu bir TempData mesajıdır.";

            return RedirectToAction("Tempdata");
            //viewdate ve viewbug sadece kendi view inde çalışır
            //ama tempdata farklı actionların viewinde kullanılabilir.
            //return View();
        }
        public ActionResult Tempdata()
        {
            return View();
        }
    }
}