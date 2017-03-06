using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string brand, string model, string age)
        {
            return View();
        }
    }
}