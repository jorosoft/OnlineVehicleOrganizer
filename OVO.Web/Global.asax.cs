using System;
using System.Data.Entity;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using OVO.Data;
using OVO.Data.Migrations;
using OVO.Services;
using OVO.Services.DataServices;
using OVO.Data.Models;
using OVO.Data.Repositories;

namespace OVO.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static double TimerIntervalInMilliseconds =
            Convert.ToDouble(WebConfigurationManager.AppSettings["TimerIntervalInMilliseconds"]);

        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OVOMsSqlDbContext, Configuration>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            var timer = new System.Timers.Timer(TimerIntervalInMilliseconds);

            timer.Enabled = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);

            timer.Start();
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

        static async void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var ctx = new OVOMsSqlDbContext();
            var maintenance = new DailyMaintenanceService(
                new EmailSendService(),
                new VehiclesService(new EfRepository<Vehicle>(ctx),
                new SaveContext(ctx)));

            await maintenance.Execute();
        }
    }
}
