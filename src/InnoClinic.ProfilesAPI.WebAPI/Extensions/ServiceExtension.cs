using InnoClinic.ProfilesAPI.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace InnoClinic.ProfilesAPI.WebAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Profile API",
                    Description = "This Api will be responsible for overall data distribution in Profiles"
                });

                options.EnableAnnotations();
                options.DescribeAllParametersInCamelCase();

                //options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                //{
                //    Name = "Authorization",
                //    In = ParameterLocation.Header,
                //    Type = SecuritySchemeType.ApiKey,
                //    Scheme = "Bearer",
                //    BearerFormat = "JWT",
                //    Description = "Input your Bearer token in this format - Bearer {your token here}"
                //});

                //options.AddSecurityRequirement(new OpenApiSecurityRequirement
                //{
                //    {
                //        new OpenApiSecurityScheme
                //        {
                //            Reference = new OpenApiReference
                //            {
                //                Type = ReferenceType.SecurityScheme,
                //                Id = "Bearer"
                //            },
                //            Scheme = "Bearer",
                //            Name = "Bearer",
                //            In = ParameterLocation.Header,
                //        },
                //        new List<string>()
                //    },
                //});
            });
        }

        

        public static void AddApiVersionExtension(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }
    }
}
