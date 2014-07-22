using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso_DBFirst.Models;
using Contoso_DBFirst.ViewModels;
using System.Data.Entity;

namespace Contoso_DBFirst.Controllers
{
   public class HomeController : Controller
   {
      private ContosoUniversityEntities db = new ContosoUniversityEntities();

      public ActionResult Index()
      {
         return View();
      }

      public ActionResult About()
      {
         IQueryable<EnrollmentDateGroup> data = 
               from s in db.Students 
               group s by s.EnrollmentDate into dateGroup
               select new EnrollmentDateGroup(){
                  EnrollmentDate = dateGroup.Key,
                  StudentCount = dateGroup.Count()
               };
          return View(data.ToList());
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Mój kontakt...";

         return View();
      }



      protected override void Dispose(bool disposing)
      {
         db.Dispose();
 	      base.Dispose(disposing);
      }

   }
}