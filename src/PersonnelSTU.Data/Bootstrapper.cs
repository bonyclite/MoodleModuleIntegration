﻿using System;
using Autofac;
using Autofac.Builder;
using Common.Data;
using PersonnelSTU.Data.Repositories;

namespace PersonnelSTU.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder, Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>> lifetimeScopeConfigurator)
        {
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