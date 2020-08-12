using System.Web;
using System.Web.Mvc;

namespace Proctica8_DiplomadoUASDCodeFirst.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
