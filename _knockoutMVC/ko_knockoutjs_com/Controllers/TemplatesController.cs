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

      public ActionResult _03_UsingASWithForeach()
      {
         return View();
      }

      public ActionResult _04_Using_afterRender_afterAdd_beforeRemove()
      {
         return View();
      }

      public ActionResult _05_DinamicallyChoosingTemplate()
      {
         return View();
      }

      public ActionResult _06_jQuery_tmpl()
      {
         return View();
      }
      
      public ActionResult _07_Underscore_js_template()
      {
         return View();
      }
      
      

      
      public ActionResult Test_Template()
      {
         return View();
      }

   }
}