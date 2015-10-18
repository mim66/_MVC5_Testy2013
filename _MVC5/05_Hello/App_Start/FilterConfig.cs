using System.Web;
using System.Web.Mvc;

namespace _05_Hello
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
         //na potrzeby autoryzacji globalnej
         filters.Add(new AuthorizeAttribute());
         // następnie dodaj AllowAnonymous attrybut do Authentication controller.
      }
   }
}
