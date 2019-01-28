using System.Web;
using System.Web.Mvc;

namespace Lab2_individualAccount_CorrectVersion_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
