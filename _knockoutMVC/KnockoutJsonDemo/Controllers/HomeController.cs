using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockoutJsonDemo.Models;
using Newtonsoft.Json;

namespace KnockoutJsonDemo.Controllers
{
    public class HomeController : Controller
    {
         private static Osoba _dane = new Osoba()
         {
            Nazwa = "Osoba 1", 
            Wiek = 29
         };


         public ActionResult Index()
         {
            return View();
         }

         public ActionResult TestJson()
         {
            return Json(new {
               Nazwa = "MojaNazwa", Wiek = 17
            }, JsonRequestBehavior.AllowGet );
         }

         public JsonResult PobierzOsobe()
         {
            return Json(_dane, JsonRequestBehavior.AllowGet);
         }

         [HttpPost]
         public JsonResult AktualizujOsobe()
         {
            string jsonString = Request.Form[0];
            Osoba osoba = JsonConvert.DeserializeObject<Osoba>(jsonString);
            _dane.Nazwa = osoba.Nazwa;
            _dane.Wiek = osoba.Wiek;
            return Json(_dane);
         }



    }
}
