using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Autofac.Builder;
using PersonnelSTU.Data;
using PersonnelSTU.FakeDBUtilAPI.Providers;

namespace PersonnelSTU.FakeDBUtilAPI
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder, Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator)
        {
            builder.RegisterType<DbProvider>().As<IDbProvider>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<FakeDbProvider>().As<IFakeDbProvider>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
        }
    }
}