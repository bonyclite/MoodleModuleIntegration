using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Builder;
using Autofac.Integration.Mvc;
using Moodle3KL.Data;

[assembly: PreApplicationStartMethod(typeof(StudentCard.Web.UI.App.AppStart), nameof(StudentCard.Web.UI.App.AppStart.Start))]
namespace StudentCard.Web.UI.App
{
    public class AppStart : global::Web.Common.App.AppStart
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

            Bootstrapper.RegisterTypes(builder, LifetimeScopeConfigurator);
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