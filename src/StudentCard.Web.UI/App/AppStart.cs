using System.Web;
using Autofac;
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

        public override void RegisterTypes(ContainerBuilder builder)
        {
            base.RegisterTypes(builder);

            Bootstrapper.RegisterTypes(builder);
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