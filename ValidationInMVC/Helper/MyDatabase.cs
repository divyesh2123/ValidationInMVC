using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidationInMVC.Helper
{
    static public class MyDatabase
    {
        public static List<string> Emails { get; set;}

         static MyDatabase()
        {
            Emails = new List<string>();
            Emails.Add("Divyesh2198@gmail.com");
            Emails.Add("Divyesh2199@gmail.com");
            Emails.Add("Divyesh2192@gmail.com");
            Emails.Add("Divyesh2194@gmail.com");
        }
    }
}