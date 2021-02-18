using System.Web;
using System.Web.Mvc;

namespace Elsayed_Mohammed_Leilla
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
