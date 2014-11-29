using System.Web;
using System.Web.Mvc;

namespace _04_2_OWIN_Katana
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
