using Autofac;

//using PersonnelSTU.Data.Infrastructure;
//using PersonnelSTU.Data.Repositories;

namespace EducationalPlans.Parser.WebApi
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
//            builder.RegisterType<PersonnelStuDbFactory>().As<IPersonnelStuDbFactory>().InstancePerRequest();
//            builder.RegisterGeneric(typeof(PersonnelSTUEntityRepository<>)).As(typeof(IPersonnelSTUEntityRepository<>))
//                .InstancePerRequest();
            
            base.Load(builder);
        }
    }
}