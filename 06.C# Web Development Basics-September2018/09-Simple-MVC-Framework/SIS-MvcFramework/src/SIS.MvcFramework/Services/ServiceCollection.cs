using System;
using System.Collections.Generic;
using System.Linq;

namespace SIS.MvcFramework.Services
{
    public class ServiceCollection : IServiceCollection
    {
        private IDictionary<Type, Type> dependencyContainer;

        public ServiceCollection()
        {
            this.dependencyContainer = new Dictionary<Type, Type>();
        }

        public void AddService<TSource, TDestination>()
        {
            dependencyContainer[typeof(TSource)] = typeof(TDestination);
        }

        public T CreateInstance<T>()
        {
            return (T)CreateInstance(typeof(T));
        }

        public object CreateInstance(Type type)
        {
            if (dependencyContainer.ContainsKey(type))
            {
                type = dependencyContainer[type];
            }

            if (type.IsInterface || type.IsAbstract)
            {
                throw new Exception($"Type {type.FullName} cannot be instantiated.");
            }

            var constructor = type.GetConstructors().First();
            var constructorParameteres = constructor.GetParameters();

            var contstructorParametererObject = new List<object>();

            foreach (var constructorParameter in constructorParameteres)
            {
                var parameterObject = this.CreateInstance(constructorParameter.ParameterType);
                contstructorParametererObject.Add(parameterObject);

            }

            var obj = constructor.Invoke(contstructorParametererObject.ToArray());

            return obj;
        }
    }
}
