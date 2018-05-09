using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Builder;
using Autofac.Integration.Mvc;
using Common;
using Common.Data;

namespace Web.Common.App
{
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    [SuppressMessage("ReSharper", "VirtualMemberNeverOverridden.Global")]
    public class AppStart
    {
        public Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>>
            LifetimeScopeConfigurator { get; }

        public AppStart(
            Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>>
                lifetimeScopeConfigurator = null)
        {
            LifetimeScopeConfigurator = lifetimeScopeConfigurator ??
                                        (registrationBuilder => registrationBuilder.InstancePerRequest());
        }

        public virtual void Run()
        {
            var builder = new ContainerBuilder();
            RegisterTypes(builder);

            builder.RegisterModule(new AutofacWebTypesModule());

            RegisterRoutes(RouteTable.Routes);
            RegisterBundles(BundleTable.Bundles);

            builder.RegisterSource(new ViewRegistrationSource());

            var container = builder.Build();
            SetDependencyResolver(container);
        }

        public virtual void RegisterTypes(ContainerBuilder builder)
        {
            Bootstrapper.RegisterTypes(builder, LifetimeScopeConfigurator);
        }

        protected virtual void RegisterBundles(BundleCollection bundleCollection)
        {
            bundleCollection.Add(new EmbeddedCommonScriptBundle("~/Scripts/jqueryBundle").IncludeFiles(
                "~/Scripts/jquery-3.3.1.slim.min.js",
                "~/Scripts/jquery-3.3.1.min.js"));

            bundleCollection.Add(new EmbeddedCommonScriptBundle("~/Scripts/bootstrap/bundle").IncludeFiles(
                "~/Scripts/popper.min.js",
                "~/Scripts/popper.js",
                "~/Scripts/popper-utils.min.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap.min.js"));

            bundleCollection.Add(new EmbeddedCommonScriptBundle("~/Scripts/modernizr/bundle").IncludeFiles(
                "~/Scripts/modernizr-2.8.3.js"));

            bundleCollection.Add(new EmbeddedCommonStyleBundle("~/Content/site/bundle").IncludeFiles(
                "~/Content/Site.css"));

            bundleCollection.Add(new EmbeddedCommonStyleBundle("~/Content/fonts/bundle").IncludeFiles(
                "~/Content/fonts/font-awesome.min.css"));

            bundleCollection.Add(new EmbeddedCommonStyleBundle("~/Content/bootstrap/bundle").IncludeFiles(
                "~/Content/bootstrap-grid.css",
                "~/Content/bootstrap-grid.min.css",
                "~/Content/bootstrap-reboot.css",
                "~/Content/bootstrap-reboot.min.css",
                "~/Content/bootstrap.css",
                "~/Content/bootstrap.min.css"));
        }

        protected virtual void RegisterRoutes(RouteCollection routeCollection)
        {
            routeCollection.LowercaseUrls = true;

            routeCollection.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routeCollection.MapRoute(
                "ScriptResources",
                "Scripts/{*file}",
                new {controller = "Resources", action = "Scripts"});
        }

        protected virtual void SetDependencyResolver(IContainer container)
        {
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            ServiceLocator.Register(serviceType => DependencyResolver.Current.GetService(serviceType));
        }
    }
}