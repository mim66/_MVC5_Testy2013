using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContosoPl.Startup))]
namespace ContosoPl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
