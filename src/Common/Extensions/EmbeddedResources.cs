using System;
using System.IO;
using System.Reflection;

namespace Common.Extensions
{
    public class EmbeddedResources
    {
        public static string GetResource(Assembly assembly, string key)
        {
            string result;

            using (var stream = assembly.GetManifestResourceStream(key))
            {
                using (var reader = new StreamReader(stream ?? throw new InvalidOperationException()))
                {
                    result = reader.ReadToEnd();
                }
            }

            return result;
        }
    }
}