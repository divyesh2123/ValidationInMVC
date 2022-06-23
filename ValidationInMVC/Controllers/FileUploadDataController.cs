using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Helper;

namespace ValidationInMVC.Controllers
{
   
    public class FileUploadDataController : Controller
    {
        // GET: FileUploadData
        public ActionResult Index()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            var file = Request.Files[0];

          

            if (file.ContentLength > 0)
            {
                string _FileName = Path.GetFileName(file.FileName);
                string _path = Path.Combine(Server.MapPath("~/myData"), _FileName);
                file.SaveAs(_path);
            }
           
            return View();

            
        }



    }
}