using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using PushNotifying.API.MessageConsumers;

namespace PushNotifying.API.Infrastructure
{
    public static class MassTransitServiceCollectionExtensions
    {
		public static IServiceCollection AddCustomMassTransit(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                x.AddConsumer<PushNotificationConsumer>();

                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.ReceiveEndpoint("order-service", e =>
                    {
                        e.ConfigureConsumer<PushNotificationConsumer>(context);
                    });
                });
            });

            services.AddMassTransitHostedService();

            return services;
        }
	}
}