using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories;
using MediatR;
using Microsoft.OpenApi.Models;
using InnoClinic.ProfilesAPI.UseCases.Mappings;

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
            });
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IPatientRepository, PatientRepository>();

            
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(typeof(MappingProfile));
        }

        //public static void AddApiVersionExtension(this IServiceCollection services)
        //{
        //    services.AddApiVersioning(config =>
        //    {
        //        config.DefaultApiVersion = new ApiVersion(1, 0);
        //        config.AssumeDefaultVersionWhenUnspecified = true;
        //        config.ReportApiVersions = true;
        //    });
        //}
    }
}
