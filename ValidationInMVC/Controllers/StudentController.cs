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
            return File(Server.MapPath("~/data/TextFile1.txt"), "text/plain");
        }

    }
}