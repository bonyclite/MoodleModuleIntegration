using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }
    }
}