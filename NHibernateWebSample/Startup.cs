using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHibernateWebSample.Startup))]
namespace NHibernateWebSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
