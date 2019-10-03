using System.Web;
using System.Web.Mvc;

namespace ShoppingCart_Team7B
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
