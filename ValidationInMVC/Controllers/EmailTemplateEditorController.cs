using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationInMVC.Controllers
{
    public class EmailTemplateEditorController : Controller
    {
        // GET: EmailTemplateEditor
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.RichTextEditorViewModel richTextEditorViewModel)
        {
            return View();
        }
    }
}