using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationInMVC.Controllers
{
    public class ProductForAdminController : Controller
    {
        // GET: ProductForAdmin
        public ActionResult Index()
        {
            ViewBag.Role = "Admin";
            List<Product> products = new List<Product>();   

            using (NorthwindEntities northwindEntities = new NorthwindEntities())
            {
                products = northwindEntities.Products.Include(y=>y.Category).ToList();

            }

                return View(products);
        }
    }
}