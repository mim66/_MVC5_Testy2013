using System.Web;
using System.Web.Mvc;

namespace _5_SignalR_Mvc5_T1
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
