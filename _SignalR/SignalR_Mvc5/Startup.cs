using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(SignalR_Mvc5.Startup))]
namespace SignalR_Mvc5
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
