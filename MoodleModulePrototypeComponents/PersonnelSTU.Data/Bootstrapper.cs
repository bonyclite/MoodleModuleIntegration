﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Autofac.Builder;
using Common.Data;
using Common.Data.Infrastructure;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Data.Providers;

namespace PersonnelSTU.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder, Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator)
        {
            builder.RegisterType<SqlProvider>().As<ISqlProvider>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<PersonnelStuDbFactory>().As<IDbFactory>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
        }
    }
}