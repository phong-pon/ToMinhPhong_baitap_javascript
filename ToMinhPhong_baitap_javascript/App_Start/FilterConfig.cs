using System.Web;
using System.Web.Mvc;

namespace ToMinhPhong_baitap_javascript
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
