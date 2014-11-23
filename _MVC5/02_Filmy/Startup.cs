using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02_Filmy.Startup))]
namespace _02_Filmy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
