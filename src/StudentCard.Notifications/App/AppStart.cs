using System;
using Autofac;
using Autofac.Builder;
using Common.Data;
using Common.Data.Infrastructure;
using Moodle3KL.Data.Infrastructure;
using Moodle3KL.Data.Repositories;
using StudentCard.Notifications.Services;
using Bootstrapper = Moodle3KL.Data.Bootstrapper;

namespace StudentCard.Notifications.App
{
    public class AppStart
    {
        public IContainer Run()
        {
            var builder = new ContainerBuilder();
            RegisterTypes(builder);

            var container = builder.Build();

            return container;
        }

        public virtual void RegisterTypes(ContainerBuilder builder)
        {
            Bootstrapper.RegisterTypes(builder);
            builder.RegisterType<NotificationService>().As<INotificationService>().PropertiesAutowired();
        }
    }
}