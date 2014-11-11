using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ko_knockoutjs_com.Controllers
{
   public class TemplatesController : Controller
   {
      // GET: Templates
      public ActionResult _01_NamedTemplate()
      {
         return View();
      }

      public ActionResult _02_NamedTempWithForeach()
      {
         return View();
      }


      public ActionResult Test_KO()
      {
         return View();
      }

   }
}