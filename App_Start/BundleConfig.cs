using System.Web;
using System.Web.Optimization;

namespace Attendance
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/main").Include("~/Scripts/main.js"));

            bundles.UseCdn = true;
            //var iconScout = "https://unicons.iconscout.com/release/v4.0.0/css/line.css";
            //bundles.Add(new StyleBundle("~/Content/iconScout").Include(iconScout));

            bundles.Add(new StyleBundle("~/Content/about").Include("~/Content/about.css"));
            bundles.Add(new StyleBundle("~/Content/course").Include("~/Content/course.css"));
            bundles.Add(new StyleBundle("~/Content/contact").Include("~/Content/contact.css"));
            bundles.Add(new StyleBundle("~/Content/style").Include("~/Content/style.css"));

            //Admin Style
            bundles.Add(new StyleBundle("~/Content/adminlayout").Include("~/Content/adminlayout.css"));
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"));
        }
    }
}
