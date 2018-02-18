﻿using System;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Builder;
using Autofac.Integration.Mvc;
using Common;

namespace Web.Common.App
{
    public class AppStart
    {
        public Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> LifetimeScopeConfigurator { get; }

        public AppStart(Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator = null)
        {
            LifetimeScopeConfigurator = lifetimeScopeConfigurator ?? (registrationBuilder => registrationBuilder.InstancePerRequest());
        }

        public virtual void Run()
        {
            var builder = new ContainerBuilder();
            RegisterTypes(builder);

            builder.RegisterModule(new AutofacWebTypesModule());

            RegisterRoutes();
            RegisterBundles();

            builder.RegisterSource(new ViewRegistrationSource());

            var container = builder.Build();
            SetDependencyResolver(container);
        }

        public virtual void RegisterTypes(ContainerBuilder builder)
        {
            PersonnelSTU.Data.Bootstrapper.RegisterTypes(builder, LifetimeScopeConfigurator);
        }

        protected virtual void RegisterBundles()
        {
            BundleConfig.RegisterBundles();
        }

        protected virtual void RegisterRoutes()
        {
            RouteTable.Routes.LowercaseUrls = true;

            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            RouteTable.Routes.MapRoute(
                "ScriptResources",
                "Scripts/{*file}",
                new { controller = "Resources", action = "Scripts" });
        }

        protected virtual void SetDependencyResolver(IContainer container)
        {
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            ServiceLocator.Register(serviceType => DependencyResolver.Current.GetService(serviceType));
        }
    }
}