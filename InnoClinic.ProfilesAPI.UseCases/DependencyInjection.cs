using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace InnoClinic.ProfilesAPI.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
