using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Helper;

namespace ValidationInMVC.Controllers
{
    public class StudentController : Controller
    {



        // GET: Student
        public JsonResult Index()
        {
            var a = 5;
            var b = 0;

            var c = a / b;

            Employee employee = new Employee();
            employee.FirstName = "Divyesh";
            employee.LastName = "Patel";
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        public JavaScriptResult Javascript()
        {
            return JavaScript("alert('test')");
        }

        public FileResult MyPage()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/data/TextFile1.txt"));
            string fileName = "myfile.ext";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
           
        }

    }
}