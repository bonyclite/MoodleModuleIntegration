using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class ServiceLocator
    {
        private static Func<Type, object> _globalProvider;

        [ThreadStatic]
        private static Func<Type, object> _currentThreadProvider;

        public static void Register(Func<Type, object> provider)
        {
            _globalProvider = provider;
        }

        public static void DisposeProviderForCurrentThread()
        {
            _currentThreadProvider = null;
        }

        public static TService Get<TService>()
            where TService : class
        {
            return (TService)Get(typeof(TService));
        }

        public static object Get(Type serviceType)
        {
            return (_currentThreadProvider ?? _globalProvider)(serviceType);
        }
    }
}