﻿using System.Web;
using System.Web.Mvc;

namespace Milestone_CST350
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
