using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

// Install-Package BetterCMS.Module.Users
using System.Security.Principal;
using BetterCms.Core;
using BetterCms.Core.Environment.Host;
    
namespace Tut_BetterCMS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static ICmsHost cmsHost;

        protected void Application_Start() {
           cmsHost = CmsContext.RegisterHost();

           //AreaRegistration.RegisterAllAreas();

           //WebApiConfig.Register(GlobalConfiguration.Configuration);
           //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
           //RouteConfig.RegisterRoutes(RouteTable.Routes);

           /* DO NOT FORGET TO REMOVE DEFAULT ROUTE REGISTRATION! 
              FOLLOWING SOURCE CODE SHOULD BE REMOVED: 
              routes.MapRoute(
                       name: "Default",
                       url: "{controller}/{action}/{id}",
                       defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                   );
           */
           // [YOUR CODE]
           cmsHost.OnApplicationStart(this);
        }

        protected void Application_BeginRequest() {
           // [YOUR CODE]
           cmsHost.OnBeginRequest(this);
        }

        protected void Application_EndRequest() {
           // [YOUR CODE]
           cmsHost.OnEndRequest(this);
        }

        protected void Application_Error() {
           // [YOUR CODE]
           cmsHost.OnApplicationError(this);
        }

        protected void Application_End() {
           // [YOUR CODE]
           cmsHost.OnApplicationEnd(this);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {
           // [YOUR CODE]
           // Uncomment following source code for a quick Better CMS test if you don't have implemented users authentication. 
           // Do not use this code for production!
           /*
           var roles = new[] { "BcmsEditContent", "BcmsPublishContent", "BcmsDeleteContent", "BcmsAdministration" };
           var principal = new GenericPrincipal(new GenericIdentity("TestUser"), roles);
           HttpContext.Current.User = principal;
           */

           cmsHost.OnAuthenticateRequest(this);
        }


    }
}