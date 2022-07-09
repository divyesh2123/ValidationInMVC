using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Models;

namespace ValidationInMVC.Controllers
{
    public class ProductFromAPIController : Controller
    {
        // GET: ProductFromAPI
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync("https://localhost:44343/api/Employee");
                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();



                    var products = JsonConvert.DeserializeObject<List<ProdcutViewModel>>(responseBody);

                    var productjson = JsonConvert.SerializeObject(products);
                    return View(products);
                }

            }
        }
    }
}