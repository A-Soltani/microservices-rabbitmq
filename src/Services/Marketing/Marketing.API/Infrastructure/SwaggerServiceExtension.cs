using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Marketing.API.Infrastructure.Swagger
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
                    Title = "Marketing.API",
                    Version = "v1",
                    Description = "The Portal Marketing Service API",
                });
            });

            return services;
        }
	}
}