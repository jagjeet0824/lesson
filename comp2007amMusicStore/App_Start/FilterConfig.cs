﻿using System.Web;
using System.Web.Mvc;

namespace comp2007amMusicStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
