using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Common.Extensions
{
    public static class ReflectionExtensions
    {
        public static IEnumerable<PropertyInfo> GetPublicInstanceProperties(this Type self)
        {
            if (self == null)
                return Enumerable.Empty<PropertyInfo>();

            return self.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        public static object GetDefault(this Type self)
        {
            if (self == null)
                return null;

            return self.IsValueType ? Activator.CreateInstance(self) : null;
        }
    }
}