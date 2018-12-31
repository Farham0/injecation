using System.Web;
using System.Web.Mvc;
using WebApplication2.Filters; 

namespace WebApplication2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomActionFilter());
        }
    }
}
