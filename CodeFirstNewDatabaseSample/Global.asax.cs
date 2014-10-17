using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using System.Data.Entity;
using CodeFirstNewDatabaseSample.Models;


namespace CodeFirstNewDatabaseSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Old code
            // Database.SetInitializer<BloggingContext>(new DatabaseInitializer());
            // New code
            Database.SetInitializer<BloggingContext>(new DropCreateDatabaseAlways<BloggingContext>());
            //Database.SetInitializer(new Initializer()); 


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
