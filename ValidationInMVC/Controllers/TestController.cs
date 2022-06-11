using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Models;

namespace ValidationInMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            EmployeeData employee = new EmployeeData();

            employee.StateData = new List<SelectListItem>();

            employee.CityData = new List<SelectListItem>();

            employee.StateData.Add(new SelectListItem
            {
                Text = "Gujrat",
                Value = "1"
            });

            employee.StateData.Add(new SelectListItem
            {
                Text = "Maharastra",
                Value = "2"
            });

            employee.StateData.Add(new SelectListItem
            {
                Text = "Karanataka",
                Value = "3"
            });




            return View(employee);
        }

        public ActionResult CityData(int stateId)
        {
            var myData = new List<CityData>()
            {
                  new CityData
                  {

               CityID =1,
               CityName ="Vadodara",
               StateId =1,


                  },

                   new CityData
                  {

               CityID =2,
               CityName ="Ahemedabad",
               StateId =1,


                  },

                      new CityData
                  {

               CityID =2,
               CityName ="Pune",
               StateId =2,


                  },



            };



            var result = myData.Where(y => y.StateId == stateId).ToList();

            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}