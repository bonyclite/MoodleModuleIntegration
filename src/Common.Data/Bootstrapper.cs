using Autofac;
using Common.Data.Infrastructure;
using Common.Data.Repositories;

namespace Common.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().PropertiesAutowired();
            builder.RegisterGeneric(typeof(EntityRepositoryBase<>)).As(typeof(IEntityRepository<>)).PropertiesAutowired();
        }
    }
}