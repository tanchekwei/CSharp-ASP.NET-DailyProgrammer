using System.Web;
using System.Web.Mvc;

namespace Smooshed_Morse_Code_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
