using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_Filmy.Controllers
{
   public class WitajSwiecieController : Controller
   {
      // GET: WitajSwiecie
      public ActionResult Index()
      {
         return View();
      }

      //public string Index()
      //{
      //   return "To jest moja <b>domyślna</b> akcja...";
      //}

      
      // GET: /WitajSwiecie/Powitanie/mim/3 
      // po doddaniu
      //          routes.MapRoute(
      //               name: "Hello",
      //               url: "{controller}/{action}/{nazwa}/{id}"
      //         );

      // GET: /WitajSwiecie/Powitanie?nazwa=mim&numer=3
      public ActionResult Powitanie(string nazwa, int numer)
      {
         ViewBag.Nazwa = "Hello " + nazwa;
         ViewBag.Numer = numer;

         return View();
      }

      //// GET: /WitajSwiecie/Powitanie?nazwa=mim&numer=3
      //public string Powitanie(string nazwa, int ID)
      //{
      //   return HttpUtility.HtmlEncode("Hello " + nazwa + ", ID to: " + ID);
      //}

      //// 
      //// GET: /WitajSwiecie/Powitanie?nazwa=mim&numer=3
      //public string Powitanie(string nazwa, int numer)
      //{
      //   return HttpUtility.HtmlEncode("Hello " + nazwa + ", Numer to: " + numer);
      //}

      // GET: /WitajSwiecie/Powitanie/ 
      //public string Powitanie()
      //{
      //   return "To jest Powitanie...";
      //} 
   }
}