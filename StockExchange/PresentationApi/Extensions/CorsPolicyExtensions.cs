using Microsoft.Extensions.Options;

namespace WebApi.Extensions
{
    public static class CorsPolicyExtensions
    {
        public static void ConfigureCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy("AllowOrigin",
       builder => builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
       .AllowAnyMethod().
       AllowCredentials()
       .SetPreflightMaxAge(TimeSpan.FromMinutes(5)));
            });
        }
    }
}
