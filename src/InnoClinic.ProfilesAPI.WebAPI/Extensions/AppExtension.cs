using Swashbuckle.AspNetCore.SwaggerUI;

namespace InnoClinic.ProfilesAPI.WebAPI.Extensions
{
    public static class AppExtension
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "ProfilesAPI");

                options.DefaultModelRendering(ModelRendering.Model);
            });
        }
    }
}
