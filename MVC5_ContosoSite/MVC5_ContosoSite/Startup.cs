using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_ContosoSite.Startup))]
namespace MVC5_ContosoSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
