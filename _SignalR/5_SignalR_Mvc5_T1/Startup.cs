using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(_5_SignalR_Mvc5_T1.Startup))]
namespace _5_SignalR_Mvc5_T1
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         // Any connection or hub wire up and configuration should go here
         app.MapSignalR();
      }
   }
}