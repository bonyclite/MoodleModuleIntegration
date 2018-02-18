using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Common.Extensions;

namespace Common
{
    public static class EmbeddedResourceUtil
    {
        public static bool TryGetResourceName(string virtualPath, Assembly assembly, out string result)
        {
            result = GetResourceName(virtualPath, new[] { assembly }, out _);

            return !result.IsEmpty();
        }

        private static string GetResourceName(string virtualPath, IEnumerable<Assembly> searchIn, out Assembly foundIn)
        {
            virtualPath = virtualPath.TrimStart('~', '/');
            var dirName = (Path.GetDirectoryName(virtualPath) ?? "").Replace("-", "_");
            var fileName = Path.GetFileName(virtualPath);

            var resourcePath = Path.Combine(dirName, fileName).Replace("\\", ".").Replace("/", ".");
            string resourceName = null;
            foundIn = searchIn.FirstOrDefault(a =>
            {
                var rName = a.GetName().Name + "." + resourcePath;
                resourceName = a.GetManifestResourceNames().FirstOrDefault(r => r.EqualsIgnoringCase(rName));

                return !resourceName.IsEmpty();
            });

            return resourceName;
        }
    }
}