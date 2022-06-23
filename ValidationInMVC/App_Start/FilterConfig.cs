using System.Web;
using System.Web.Mvc;
using ValidationInMVC.Helper;

namespace ValidationInMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogAttribute());
        }
    }
}
