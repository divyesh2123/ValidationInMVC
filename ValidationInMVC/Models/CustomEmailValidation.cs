using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ValidationInMVC.Helper;

namespace ValidationInMVC.Models
{
    public class CustomEmailValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
           if(value != null)
            {
                var myData = MyDatabase.Emails.Contains(value);

                return !myData;



            }

            return true;

        }
    }
}