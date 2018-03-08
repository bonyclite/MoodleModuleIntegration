using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Common.Extensions;

namespace Web.Common.App.Extensions
{
    public static class UrlHelper
    {
        public static string ToAbsoluteUrlWith(this string self, string rootUrl)
        {
            if (self.IsEmpty())
                return self;

            var result = self;
            if (!result.IsAbsoluteUrl())
                result = rootUrl.CombineAbsoluteUrlWith(self);

            return result;
        }

        public static bool IsAbsoluteUrl(this string self)
        {
            return UrlValidator.Validate(self, UriKind.Absolute);
        }

        public static string GetRootUrl(this HttpRequestBase self)
        {
            var result = self.GetUri().GetLeftPart(UriPartial.Authority);
            return result;
        }

        public static string CombineAbsoluteUrlWith(this string self, string relativeUrl)
        {
            if (!self.IsAbsoluteUrl())
                throw new ArgumentException("Must be absolute url.", nameof(self));

            if (relativeUrl.IsAbsoluteUrl())
                throw new ArgumentException("Must be relative url.", nameof(relativeUrl));

            if (!self.EndsWith("/"))
                self = self + "/";

            var uri = new Uri(self);
            return new Uri(uri, relativeUrl.TrimStart('/')).ToString();
        }
    }
}