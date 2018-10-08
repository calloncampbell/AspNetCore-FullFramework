using Autofac;
using ClassLibrary.Complete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Complete.IocModule
{
    public class IocApiModule : Module
    {
        //private readonly IConfigurationRoot _configuration;

        ///// <summary>
        ///// Initializes a new instance of the <see cref="IocApiModule"/> class.
        ///// </summary>
        ///// <param name="configuration">The configuration.</param>
        //public IocApiModule(IConfigurationRoot configuration)
        //{
        //    _configuration = configuration;
        //}

        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<Class1>().As<IClass1>().InstancePerLifetimeScope();
        }
    }
}
