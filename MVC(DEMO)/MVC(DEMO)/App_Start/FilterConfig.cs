﻿using System.Web;
using System.Web.Mvc;

namespace MVC_DEMO_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}