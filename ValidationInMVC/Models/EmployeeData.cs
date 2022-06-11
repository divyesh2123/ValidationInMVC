using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationInMVC.Models
{
    public class EmployeeData
    {
        public int CityId { get; set; }

        public int StateId { get; set; }

        public List<SelectListItem> StateData { get; set; }

        public List<SelectListItem> CityData { get; set; }


    }
}