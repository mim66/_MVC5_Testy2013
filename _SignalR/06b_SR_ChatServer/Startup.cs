using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(_06b_SR_ChatServer.Startup))]

namespace _06b_SR_ChatServer
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
         //var hubConfiguration = new Microsoft.AspNet.SignalR.HubConfiguration();
         //hubConfiguration.EnableDetailedErrors = true;
         //hubConfiguration.EnableJavaScriptProxies = false;
         //app.MapSignalR("/myhubs", hubConfiguration);

         app.MapSignalR("/myhubs", new Microsoft.AspNet.SignalR.HubConfiguration());
      }
   }
}
