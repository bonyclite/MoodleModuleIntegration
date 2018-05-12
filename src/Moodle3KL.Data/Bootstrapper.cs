using System;
using Autofac;
using Autofac.Builder;

namespace Moodle3KL.Data
{
    public static class Bootstrapper
    {
        public static void RegisterTypes(ContainerBuilder builder,
            Func<IRegistrationBuilder<object, object, object>, IRegistrationBuilder<object, object, object>>
                lifetimeScopeConfigurator)
        {
        }
    }
}