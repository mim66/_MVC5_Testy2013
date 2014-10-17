using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
   public class HelloController : Controller
   {
      //
      // GET: /Hello/
      public ActionResult Index() {
         return View();
      }
      //public string Index() {
      //   return "To jest <b>domyślna</b> akcja...";
      //}

      //// GET: /Hello/Witamy/ 
      public ActionResult Witamy(string nazwa, int liczba = 1) {
         ViewBag.Message         = "Hello " + nazwa;
         ViewBag.LiczbaPowtorzen = liczba;
         return View();
      }
      //public string Witamy(string nazwa, int liczba = 1) {
      //   return HttpUtility.HtmlEncode("Hello " + nazwa + ", liczba powtórzeń to: " + liczba);
      //}
      //public string Witamy() {
      //   return "This is the Witamy action method...";
      //}

   }
}
