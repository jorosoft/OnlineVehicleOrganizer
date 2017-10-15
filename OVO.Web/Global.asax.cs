using System;
using System.Data.Entity;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using OVO.Data;
using OVO.Data.Migrations;
using OVO.Web.App_Start;

namespace OVO.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<OVOMsSqlDbContext, Configuration>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }

        protected void Application_BeginRequest(object sender, EventArgs ev)
        {
            var cookie = HttpContext.Current.Request.Cookies["Language"];
            var selectedValue = "en";

            if (cookie != null && cookie.Value != null)
            {
                selectedValue = cookie.Value;
            }

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedValue);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(selectedValue);
        }
    }
}
