using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace WebApplication.Complete.Builders
{
    public static class AutofacBuilder
    {
        /// <summary>
        /// Adds the dependency injections.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="modules">The modules.</param>
        /// <returns></returns>
        public static IServiceProvider AddDependencyInjections(this IServiceCollection services, params Module[] modules)
        {
            var container = (IContainer)null;
            var builder = new ContainerBuilder();

            // factories
            //builder.Register<IDependencyFactory>(ctx => new DependencyFactory(container)).SingleInstance();

            foreach (var module in modules)
            {
                builder.RegisterModule(module);
            }

            builder.Populate(services);

            container = builder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}
