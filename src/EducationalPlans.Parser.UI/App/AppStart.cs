﻿using System;
using System.Web;
using Autofac;
using Autofac.Builder;
using Autofac.Integration.Mvc;
using Common.Data;
using EducationalPlans.Parser.Api.Services;

[assembly: PreApplicationStartMethod(typeof(EducationalPlans.Parser.UI.App.AppStart), nameof(EducationalPlans.Parser.UI.App.AppStart.Start))]
namespace EducationalPlans.Parser.UI.App
{
    public class AppStart : Web.Common.App.AppStart
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

            builder.RegisterType<XmlFileParserService>().As<IXmlFileParserService>().ApplyDefaultConfiguration(LifetimeScopeConfigurator);
            builder.RegisterType<PersonnelSTUService>().As<IPersonnelSTUService>().ApplyDefaultConfiguration(LifetimeScopeConfigurator);

            Moodle3KL.Data.Bootstrapper.RegisterTypes(builder, LifetimeScopeConfigurator);
            builder.RegisterControllers(typeof(AppStart).Assembly).PropertiesAutowired();
        }

        protected override void RegisterRoutes()
        {
            base.RegisterRoutes();
            RouteConfig.RegisterRoutes();
        }
    }
}