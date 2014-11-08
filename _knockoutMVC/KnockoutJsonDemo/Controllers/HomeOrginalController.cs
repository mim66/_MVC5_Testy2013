using KnockoutJsonDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutJsonDemo.Controllers
{
    public class HomeOrginalController : Controller
    {
        //
        // GET: /HomeOrginal/

       private static Person _data = new Person()
       {
          Name = "PersonName",
          Age = 25
       };

       public ActionResult Index()
       {
          return View();
       }

       public ActionResult TestJson()
       {
          return Json(new
          {
             Name = "MyName",
             Age = "17"
          }, JsonRequestBehavior.AllowGet);
       }

       public JsonResult GetPerson()
       {
          return Json(_data, JsonRequestBehavior.AllowGet);
       }

       [HttpPost]
       public JsonResult UpdatePerson()
       {
          string jsonString = Request.Form[0];
          Person person = JsonConvert.DeserializeObject<Person>(jsonString);
          _data.Name = person.Name;
          _data.Age = person.Age;
          return Json(_data);
       }
    }
}
