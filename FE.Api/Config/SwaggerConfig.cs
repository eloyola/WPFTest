using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FE.Api.Config
{
    //C:\Users\Family\source\repos\WPFTest\FE.Api\FE.Api.xml
    public static class SwaggerConfig
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var xmlPath = Path.Combine(basePath, "FE.Api.xml");
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "API v1",
                    Version = "1"
                }
                );
                c.IncludeXmlComments(xmlPath);
            }
            ); ;
            return services;
        }

        public static IApplicationBuilder AddBuilder(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(p => p.SwaggerEndpoint("/swagger/v1/swagger.json", "CoworkingAPI v1"));
            return app;
        }
    }
}
