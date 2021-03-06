using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Models;

namespace ValidationInMVC.Controllers
{

    [HandleError(View = "_SpecificError", ExceptionType = typeof(DivideByZeroException))]
    [HandleError(Order = 2, View = "Error", ExceptionType = typeof(FormatException))]
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var a = 5;
            var b = 0;
            var d = a / b;
            return View();
        }

        [HttpPost]
        public ActionResult Index(EmployeeViewModel employeeViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(employeeViewModel);
            }

            return RedirectToAction("Index");
        }
    }
}