using Autofac;
using Common.Data.Infrastructure;
using Moodle3KL.Data.Infrastructure;
using Moodle3KL.Data.Repositories;

namespace Moodle3KL.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<Moodle3KLDbFactory>().As<IDbFactory>().PropertiesAutowired();
            builder.RegisterGeneric(typeof(MdlEntityRepositoryBase<>)).As(typeof(IMdlEntityRepositoryBase<>)).PropertiesAutowired();
        }
    }
}