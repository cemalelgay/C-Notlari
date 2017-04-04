using ApiSample2.Service.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ApiSample_2.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:65021/api/Category");

                var result = JsonConvert.DeserializeObject<List<ApiSample_2.Web.Models.Kategori>>(response.Content.ReadAsStringAsync().Result);

                return View(result);
            }
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Add(Kategori cat)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:65021");
                //var result = await client.PostAsync("/api/Category", ()cat);

                var formContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("CategoryName", cat.CategoryName)
                });
                var result = await client.PostAsync("/api/Category", formContent);
            }
            return View();
        }
    }
}