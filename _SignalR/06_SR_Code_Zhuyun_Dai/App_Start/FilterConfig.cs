using System.Web;
using System.Web.Mvc;

namespace _06_SR_Code_Zhuyun_Dai
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
