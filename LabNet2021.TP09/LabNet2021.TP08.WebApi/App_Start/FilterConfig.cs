﻿using System.Web;
using System.Web.Mvc;

namespace LabNet2021.TP08.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
