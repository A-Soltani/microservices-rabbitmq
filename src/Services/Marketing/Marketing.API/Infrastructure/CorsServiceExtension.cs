﻿using Microsoft.Extensions.DependencyInjection;

namespace Marketing.API.Infrastructure.CustomExtentions
{
    public static class CorsServiceExtension
    {
		public static IServiceCollection AddCustomCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .SetIsOriginAllowed((host) => true)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });

            return services;
        }
	}
}