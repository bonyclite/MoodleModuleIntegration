using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web.Common
{
    public static class UrlValidator
    {
        public static bool Validate(string url, UriKind kind)
        {
            return Uri.TryCreate(url, kind, out _);
        }
    }
}