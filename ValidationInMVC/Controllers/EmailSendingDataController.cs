using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ValidationInMVC.Controllers
{
    public class EmailSendingDataController : Controller
    {
        // GET: EmailSendingData
        public ActionResult Index()
        {
            using (EmailTemplateManagmentEntities emailTemplate = new EmailTemplateManagmentEntities())
            {
                var myEmailTemplate = emailTemplate.EmailTemplates.Where(y => y.ID == 1).FirstOrDefault();

                var data = new StringBuilder(myEmailTemplate.EmailBody);
                data.Replace("##FirstName", "divyesh");
                data.Replace("##LastName", "Patel");
                data.Replace("##link", "");








            }


                return View();
        }
    }
}