using MVC_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Ogrenci> Ogrenciler = new List<Ogrenci>();

            Ogrenci ogr1 = new Ogrenci();
            ogr1.id = 1;
            ogr1.Name = "Yavuz";
            ogr1.Surname = "Gedik";
            ogr1.StudentNumber = 333;

            Ogrenci ogr2 = new Ogrenci()
            {
                id = 2,
                Name = "Cemal",
                Surname = "Elgay",
                StudentNumber = 50
            };
            Ogrenciler.Add(ogr2);
            Ogrenci ogr3 = new Ogrenci()
            {
                id = 3,
                Name = "Tuğçe",
                Surname = "Güngörmüş",
                StudentNumber = 11
            };
            Ogrenciler.Add(ogr3);

            Ogrenci ogr4 = new Ogrenci()
            {
                id = 4,
                Name = "Yankı",
                Surname = "Karayılan",
                StudentNumber = 100
            };
            Ogrenciler.Add(ogr4);

            Ogrenci ogr5 = new Ogrenci()
            {
                id = 5,
                Name = "Ozan",
                Surname = "Kavrama",
                StudentNumber = 10
            };
            Ogrenciler.Add(ogr5);
            Ogrenci ogr6 = new Ogrenci()
            {
                id = 6,
                Name = "Ezgi",
                Surname = "Canbaz",
                StudentNumber = 20
            };
            Ogrenciler.Add(ogr6);

            Ogrenci ogr7 = new Ogrenci()
            {
                id = 7,
                Name = "Ozan",
                Surname = "Arpaçay",
                StudentNumber = 47
            };
            Ogrenciler.Add(ogr7);

            ViewBag.ogrenciList = Ogrenciler;
            return View();
        }
    }
}