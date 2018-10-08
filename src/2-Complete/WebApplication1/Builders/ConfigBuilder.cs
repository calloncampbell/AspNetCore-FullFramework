using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.Complete.Builders
{
    public static class ConfigBuilder
    {
        /// <summary>
        /// Adds the configurations.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns></returns>
        public static IServiceCollection AddConfigurations(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddOptions();

            //services.Configure<ElasticsearchSettings>((settings) =>
            //{
            //    var configSettings = configuration.GetSection("ElasticsearchSettings");
            //    foreach (var setting in configSettings.GetChildren())
            //    {
            //        settings.Add(setting.Key, setting.Value);
            //    }
            //});

            // add additional configuration types, if necessary.

            return services;
        }
    }
}
