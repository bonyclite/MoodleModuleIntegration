using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Hosting;
using System.Web.Optimization;
using Common;
using Common.Extensions;

namespace Web.Common.App
{
    public class EmbeddedCommonStyleBundle : EmbeddedStyleBundle
    {
        public EmbeddedCommonStyleBundle(string virtualPath)
            : base(virtualPath, typeof(AppStart).Assembly)
        {
        }
    }

    public class EmbeddedCommonScriptBundle : EmbeddedScriptBundle
    {
        public EmbeddedCommonScriptBundle(string virtualPath)
            : base(virtualPath, typeof(AppStart).Assembly)
        {
        }
    }

    public class EmbeddedStyleBundle : EmbeddedResourceBundle
    {
        public EmbeddedStyleBundle(string virtualPath, Assembly resourceAssembly)
            : base(virtualPath, resourceAssembly)
        {
            // minification is performed by an external system
        }
    }
    public class EmbeddedScriptBundle : EmbeddedResourceBundle
    {
        public EmbeddedScriptBundle(string virtualPath, Assembly resourceAssembly)
            : base(virtualPath, resourceAssembly)
        {
            // minification is performed by an external system
            ConcatenationToken = ";";
        }        
    }

    public class EmbeddedResourceBundle : Bundle
    {
        private readonly List<BundleFile> _files = new List<BundleFile>();
        private readonly Assembly _resourceAssembly;

        public sealed override IBundleOrderer Orderer
        {
            get => base.Orderer;
            set => base.Orderer = value;
        }

        public EmbeddedResourceBundle(string virtualPath, Assembly resourceAssembly)
            : base(virtualPath)
        {
            _resourceAssembly = resourceAssembly;
            Orderer = new BundleNullOrderer();
        }

        public virtual EmbeddedResourceBundle IncludeFiles(params string[] virtualPaths)
        {
            foreach (var path in virtualPaths)
            {
                if (!System.IO.Path.HasExtension(path))
                    throw new InvalidOperationException("Virtual path {0} must point to a file.".FormatText(path));

                var found = EmbeddedResourceVirtualFile.Find(path, _resourceAssembly);
                _files.Add(new BundleFile(path, found));
            }

            return this;
        }

        public override IEnumerable<BundleFile> EnumerateFiles(BundleContext context)
        {
            return _files;
        }

        public override BundleResponse CacheLookup(BundleContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (!IsCacheEnabled(context))
                return null;

            return context.HttpContext.Cache[GetCacheKey(context)] as BundleResponse;
        }

        public override void UpdateCache(BundleContext context, BundleResponse response)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (response == null)
                throw new ArgumentNullException(nameof(response));

            if (IsCacheEnabled(context))
                context.HttpContext.Cache.Insert(GetCacheKey(context), response);
        }

        private bool IsCacheEnabled(BundleContext context)
        {
            return !context.EnableInstrumentation && context.HttpContext?.Cache != null;
        }
    }

    public class EmbeddedResourceVirtualFile : VirtualFile
    {
        private readonly string _resourcePath;
        private readonly Assembly _assembly;

        public EmbeddedResourceVirtualFile(string resourcePath, Assembly assembly, string virtualPath)
            : base(virtualPath)
        {
            _resourcePath = resourcePath;
            _assembly = assembly;
        }

        public override Stream Open()
        {
            var stream = _assembly.GetManifestResourceStream(_resourcePath);
            if (stream == null)
                throw new InvalidOperationException("Failed to read {0}.".FormatText(_resourcePath));

            return stream;
        }

        public static EmbeddedResourceVirtualFile Find(string virtualPath, Assembly assembly)
        {
            if (virtualPath.IsEmpty() || assembly == null)
                return null;

            if (virtualPath.Contains("*"))
                throw new NotSupportedException("'*' search pattern is not supported.");
            if (virtualPath.Contains("{version}"))
                throw new NotSupportedException("'{version}' search pattern is not supported.");

            if (!EmbeddedResourceUtil.TryGetResourceName(virtualPath, assembly, out var foundResourcePath))
                throw new InvalidOperationException("No embedded resource found by path '{0}'.".FormatText(virtualPath));

            return new EmbeddedResourceVirtualFile(foundResourcePath, assembly, virtualPath);
        }
    }
}