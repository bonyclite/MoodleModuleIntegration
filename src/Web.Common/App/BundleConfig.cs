using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace Web.Common.App
{
    public static class BundleConfig
    {
        public static void RegisterBundles()
        {
            BundleTable.EnableOptimizations = true;

            BundleTable.Bundles.Add(new EmbeddedCommonScriptBundle("~/Scripts/jqueryBundle").IncludeFiles(
                "~/Scripts/jquery-3.3.1.slim.min.js",
                "~/Scripts/jquery-3.3.1.min.js"));

            BundleTable.Bundles.Add(new EmbeddedCommonScriptBundle("~/Scripts/modernizr/bundle").IncludeFiles(
                "~/Scripts/modernizr-2.8.3.js"));

            BundleTable.Bundles.Add(new EmbeddedCommonScriptBundle("~/Scripts/bootstrap/bundle").IncludeFiles(
                "~/Scripts/esm/popper.min.js",
                "~/Scripts/esm/popper-utils.min.js",
                "~/Scripts/umd/popper.min.js",
                "~/Scripts/umd/popper-utils.min.js",
                "~/Scripts/popper.min.js",
                "~/Scripts/popper-utils.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/bootstrap.bundle.min.js"));

            BundleTable.Bundles.Add(new EmbeddedCommonStyleBundle("~/Content/site/bundle").IncludeFiles(
                "~/Content/Site.css"));

            BundleTable.Bundles.Add(new EmbeddedCommonStyleBundle("~/Content/fonts/bundle").IncludeFiles(
                "~/Content/fonts/font-awesome.min.css"));

            BundleTable.Bundles.Add(new EmbeddedCommonStyleBundle("~/Content/bootstrap/bundle").IncludeFiles(
                "~/Content/bootstrap-grid.css",
                "~/Content/bootstrap-grid.min.css",
                "~/Content/bootstrap-reboot.css",
                "~/Content/bootstrap-reboot.min.css",
                "~/Content/bootstrap.css",
                "~/Content/bootstrap.min.css"));
        }
    }
}