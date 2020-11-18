using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Marketing.API.Infrastructure
{
    public static class MassTransitServiceCollectionExtensions
    {
		public static IServiceCollection AddCustomMassTransit(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq();
            });

            services.AddMassTransitHostedService();

            return services;
        }
	}
}