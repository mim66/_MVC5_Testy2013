using _05_Hello.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_Hello.Filtry
{
   public class FiltrNaglStopka : ActionFilterAttribute
   {
      public override void OnActionExecuted(ActionExecutedContext filterContext) {
         //base.OnActionExecuted(filterContext);
         ViewResult v = filterContext.Result as ViewResult;
         if (v != null)
	      {
            PodstawowyViewModel pvm = v.Model as PodstawowyViewModel;
		      if (pvm != null){
               pvm.NazwaUsera = HttpContext.Current.User.Identity.Name;
               pvm.StopkaDane = new StopkaViewModel();
               pvm.StopkaDane.NazwaFirmy = "StepByStepSchools";
               pvm.StopkaDane.Rok = DateTime.Now.Year.ToString();
            }
	      }

      }
   }
}