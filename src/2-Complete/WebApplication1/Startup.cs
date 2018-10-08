using System;
using System.Configuration;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using ReflectInsight.Extensions.Logging;
using AspNet.Plus.Infrastructure.Builder;
using WebApplication.Complete.Builders;
using WebApplication.Complete.IocModule;

namespace WebApplication.Complete
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="env">The env.</param>
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddConfigurations(Configuration);
            services.AddExceptionInterceptManager();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            return services.AddDependencyInjections(new IocApiModule());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddReflectInsight("ReflectInsight.config");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors();
            app.UseHttpsRedirection();
            app.UseMvc();

            ConfigureApplicationInsights();
        }

        /// <summary>
        /// Configures the application insights.
        /// </summary>
        private static void ConfigureApplicationInsights()
        {
            bool enableTelemetry = bool.Parse(ConfigurationManager.AppSettings["ApplicationInsights.EnableTelemetry"] ?? "true");
            TelemetryConfiguration.Active.DisableTelemetry = !enableTelemetry;
        }
    }
}
