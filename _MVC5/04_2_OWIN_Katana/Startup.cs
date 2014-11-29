using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_04_2_OWIN_Katana.Startup))]
namespace _04_2_OWIN_Katana
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
