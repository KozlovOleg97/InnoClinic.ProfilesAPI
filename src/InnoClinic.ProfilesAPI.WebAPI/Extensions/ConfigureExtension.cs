using InnoClinic.ProfilesAPI.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace InnoClinic.ProfilesAPI.WebAPI.Extensions
{
    public static class ConfigureExtension
    {
        public static void ConfigureDbConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProfileDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                        assembly => assembly.MigrationsAssembly("InnoClinic.ProfilesAPI.WebAPI"));
            });
        }

        
    }
}
