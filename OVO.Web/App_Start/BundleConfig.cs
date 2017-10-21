using System.Web;
using System.Web.Optimization;

namespace OVO.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/signalr").Include(
                        "~/Scripts/jquery.signalR*"));

            bundles.Add(new ScriptBundle("~/bundles/chat").Include(
                        "~/Scripts/Custom/chat.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-tooltip.js",
                      "~/Scripts/bootstrap-popover.js",
                      "~/Scripts/business_ltd_1.0.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/Custom/menu-init.js"));

            bundles.Add(new ScriptBundle("~/bundles/mod-man-link").Include(                        
                        "~/Scripts/Custom/add-vehicle-link-dropdowns.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-responsive.min.css",
                      "~/Content/font-awesome.css",
                      "~/Content/base.css"));
        }
    }
}
