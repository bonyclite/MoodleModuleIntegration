using System;
using Autofac;
using Autofac.Builder;
using PersonnelSTU.Data.Repositories;

namespace PersonnelSTU.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder, Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator)
        {
            builder.RegisterType<FacultyRepository>().As<IFacultyRepository>().PropertiesAutowired();
            builder.RegisterType<GroupRepository>().As<IGroupRepository>().PropertiesAutowired();
            builder.RegisterType<PersonRepository>().As<IPersonRepository>().PropertiesAutowired();
            builder.RegisterType<SpecialtyRepository>().As<ISpecialtyRepository>().PropertiesAutowired();
            builder.RegisterType<StudentStateRepository>().As<IStudentStateRepository>().PropertiesAutowired();
            builder.RegisterType<StuStateRepository>().As<IStuStateRepository>().PropertiesAutowired();
            builder.RegisterType<TeacherRepository>().As<ITeacherRepository>().PropertiesAutowired();
        }
    }
}