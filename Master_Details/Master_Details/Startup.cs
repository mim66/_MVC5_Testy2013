using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Master_Details.Startup))]
namespace Master_Details
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
