using ApiSample2.Service.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
                var response = await client.GetAsync("http://localhost:65021/api/Catehory");

                var result = JsonConvert.DeserializeObject<List<Kategori>>(response.Content.ReadAsStringAsync().Result);

                return View(result);
            }
        }
    }
}