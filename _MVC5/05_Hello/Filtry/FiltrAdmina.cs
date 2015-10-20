using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_Hello.Filtry
{
   public class FiltrAdmina : ActionFilterAttribute
   {
      //23b
      public override void OnActionExecuting(ActionExecutingContext filterContext) 
      {
         if (!Convert.ToBoolean(filterContext.HttpContext.Session["CzyAdmin"])) {
            filterContext.Result = new ContentResult(){
               Content = "Nieautoryzowany dostęp"
            };
         } 
      }
   }
}