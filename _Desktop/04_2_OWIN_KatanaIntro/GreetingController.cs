using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_2_OWIN_KatanaIntro
{
   public class GreetingController : System.Web.Http.ApiController
   {
      public Greeting Get() 
      {
         return new Greeting { Text = "Hello World!" };
      }
   }
}
