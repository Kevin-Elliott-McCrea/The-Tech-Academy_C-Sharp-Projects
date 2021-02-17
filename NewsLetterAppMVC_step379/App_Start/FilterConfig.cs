using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC_step379
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
