using System.Web;
using System.Web.Mvc;

namespace InsertUpdateDeleteUsingMVCASP.NET_netframework_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
