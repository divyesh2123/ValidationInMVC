using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ValidationInMVC.Controllers
{
    public class ProductCommontController : Controller
    {
        // GET: ProductCommont
        public PartialViewResult Index()
        {
            List<Product> products = new List<Product>();

            using (NorthwindEntities northwindEntities = new NorthwindEntities())
            {
                products = northwindEntities.Products.Include(y => y.Category).ToList();

            }
            return PartialView("View", products);
        }
    }
}