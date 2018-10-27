using System;
using Autofac;
using Autofac.Builder;
using Common.Data.Infrastructure;
using Common.Data.Repositories;

namespace Common.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder, Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterGeneric(typeof(EntityRepositoryBase<>)).As(typeof(IEntityRepository<>)).ApplyDefaultConfiguration(lifetimeScopeConfigurator);
        }
    }

    public static class RegistrationBuilderExtensions
    {
        public static void ApplyDefaultConfiguration(this IRegistrationBuilder<object, object, object> registrationBuilder, Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator, bool dontAllowCircularDependencies = false)
        {
            lifetimeScopeConfigurator(registrationBuilder).PropertiesAutowired(dontAllowCircularDependencies ? PropertyWiringOptions.None : PropertyWiringOptions.AllowCircularDependencies);
        }
    }
}