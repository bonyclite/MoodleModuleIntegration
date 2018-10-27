using System;
using Autofac;
using Autofac.Builder;
using Common.Data;
using Common.Data.Infrastructure;
using Moodle3KL.Data.Infrastructure;
using Moodle3KL.Data.Repositories;

namespace Moodle3KL.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder,
            Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>>
                lifetimeScopeConfigurator)
        {
            builder.RegisterType<Moodle3KLDbFactory>().As<IDbFactory>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterGeneric(typeof(MdlEntityRepositoryBase<>)).As(typeof(IMdlEntityRepositoryBase<>)).ApplyDefaultConfiguration(lifetimeScopeConfigurator);
        }
    }
}