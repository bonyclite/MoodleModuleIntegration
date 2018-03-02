using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Autofac.Builder;
using Common.Data;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Data.Providers;
using PersonnelSTU.Data.Repositories;

namespace PersonnelSTU.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder, Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator)
        {
            builder.RegisterType<SqlProvider>().As<ISqlProvider>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<PersonnelStuDbFactory>().As<IPersonnelStuDbFactory>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<FacultyRepository>().As<IFacultyRepository>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<GroupRepository>().As<IGroupRepository>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<PersonRepository>().As<IPersonRepository>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<SpecialtyRepository>().As<ISpecialtyRepository>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<StudentStateRepository>().As<IStudentStateRepository>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<StuStateRepository>().As<IStuStateRepository>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
            builder.RegisterType<TeacherRepository>().As<ITeacherRepository>().ApplyDefaultConfiguration(lifetimeScopeConfigurator);
        }
    }
}