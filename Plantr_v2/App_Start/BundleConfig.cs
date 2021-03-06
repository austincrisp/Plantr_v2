﻿using System.Web;
using System.Web.Optimization;

namespace Plantr_v2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.maskedinput.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/myscripts").Include(
                      "~/Scripts/course.js",
                      "~/Scripts/map.js",
                      "~/Scripts/modal.js",
                      "~/Scripts/dialog-polyfill.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css",
                      "~/Content/dialog-polyfill.css",
                      "~/Content/mdl.css",
                      "~/Content/modal.css",
                      "~/Content/map.css",
                      "~/Content/homePage.css",
                      "~/Content/dashboard.css",
                      "~/Content/answerCreate.css",
                      "~/Content/contactCreate.css",
                      "~/Content/contactIndex.css",
                      "~/Content/contactDetail.css"));
        }
    }
}
