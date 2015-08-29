using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(_06_SR_EchoServer.Startup))]
namespace _06_SR_EchoServer
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         app.MapSignalR<MyConnection>("/echo");
      }
   }
}