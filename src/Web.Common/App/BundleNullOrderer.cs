using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Optimization;

namespace Web.Common.App
{
    public class BundleNullOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}