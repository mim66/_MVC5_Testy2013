using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contoso_DBFirst.Startup))]
namespace Contoso_DBFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
