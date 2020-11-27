using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace PushNotifying.API.Infrastructure
{
    public static class SwaggerServiceExtension
    {
		public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            // Register the Swagger generator
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "PushNotifying.API",
                    Version = "v1",
                    Description = "The Portal PushNotifying Service API",
                });
            });

            return services;
        }
	}
}