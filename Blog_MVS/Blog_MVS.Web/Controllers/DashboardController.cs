using Blog_MVC.DAL.Repos;
using Blog_MVC.Entity.Models;
using Blog_MVS.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVS.Web.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.Header = "Panel";
            return View();
        }

        public ActionResult AddPost()
        {
            ViewBag.Header = "Yazı Ekle";
            return View();
        }

        public ActionResult AddPost(int id)
        {
            ViewBag.Header = "Yazı Güncelle";

            var result = PostRepo.Get(id);

            return View(result);
        }

        [ValidateInput(false)] // Doğrualamayı kapatıyor.
        [HttpPost]
        public ActionResult AddPost(VMPost model)
        {

            #region Tags
            string[] etiketler = model.Tags.Split(',');

            List<Tag> tags = new List<Tag>();
            foreach (var item in etiketler)
            {
                tags.Add(new Tag { Name = item });
            }
            #endregion

            #region Category
            int catID;
            if (CategoryRepo.Get(model.Category) == null)
            {
                CategoryRepo.Add(new Category { Name = model.Category });
                catID = (CategoryRepo.Get(model.Category).CategoryID);
            }
            else
            {
                catID = (CategoryRepo.Get(model.Category).CategoryID);
            }
            #endregion

            Post yazi = new Post();
            yazi.Title = model.Title;
            yazi.PostDate = DateTime.Now;
            yazi.Contenct = model.Content;
            yazi.Tags = tags;
            yazi.CategoryID = catID;

            yazi.AdminID = 1;

            PostRepo.Add(yazi);
            return RedirectToAction("ListPost", "Dashboard");
        }
        public ActionResult ListPost()
        {
            ViewBag.Header = "Tüm Yazılar";

            var result = (PostRepo.GetAll());

            return View(result);
        }
        public ActionResult DeletePost(int id)
        {
            PostRepo.Delete(id);

            return RedirectToAction("ListPost","Dashboard");
        }
    }
}