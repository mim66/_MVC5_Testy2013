﻿using System.Web;
using System.Web.Mvc;

namespace ko_knockoutjs_com
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
