using System;
using System.Web;
using Autofac;
using Autofac.Builder;
using Autofac.Integration.Mvc;
using FakeDBUtilAPI = PersonnelSTU.FakeDBUtilAPI;
using Data = PersonnelSTU.Data;

[assembly: PreApplicationStartMethod(typeof(Web.PersonnelSTU.FakeDBUtilApp.AppStart), nameof(Web.PersonnelSTU.FakeDBUtilApp.AppStart.Start))]
namespace Web.PersonnelSTU.FakeDBUtilApp
{
    public class AppStart : Common.App.AppStart
    {
        public static void Start()
        {
            new AppStart().Run();
        }

        public AppStart(Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator = null) : base(lifetimeScopeConfigurator)
        {
        }

        public override void RegisterTypes(ContainerBuilder builder)
        {
            base.RegisterTypes(builder);           

            Data.Bootstrapper.RegisterTypes(builder, LifetimeScopeConfigurator);
            FakeDBUtilAPI.Bootstrapper.RegisterTypes(builder, LifetimeScopeConfigurator);
            builder.RegisterControllers(typeof(AppStart).Assembly).PropertiesAutowired();
        }

        protected override void RegisterBundles()
        {
            base.RegisterBundles();
            BundleConfig.RegisterBundles();
        }

        protected override void RegisterRoutes()
        {
            base.RegisterRoutes();
            RouteConfig.RegisterRoutes();
        }
    }
}