using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string self)
        {
            return string.IsNullOrEmpty(self);
        }

        public static string FormatText(this string self, params object[] args)
        {
            return string.Format(self, args);
        }

        public static bool EqualsIgnoringCase(this string self, string value)
        {
            if (self == null)
                return value == null;

            return self.Equals(value, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}