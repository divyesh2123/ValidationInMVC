using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Helper;

namespace ValidationInMVC.Controllers
{
    
    public class OutPutDataCacheController : Controller
    {
        // GET: OutPutDataCache
        [OutputCache(Duration = 10, VaryByParam = "none")]
        public ActionResult Index()
        {
            return View();
        }
    }
}