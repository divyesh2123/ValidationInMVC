using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ValidationInMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.Role = "User";

            List<Product> products = new List<Product>();

            using (NorthwindEntities northwindEntities = new NorthwindEntities())
            {
                products = northwindEntities.Products.Include(y => y.Category).ToList();

            }

            return View(products);
        }


        public ActionResult IndexJquery()
        {

            return View();
        }
    }
}