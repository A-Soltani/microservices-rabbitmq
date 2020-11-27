using Microsoft.Extensions.DependencyInjection;

namespace PushNotifying.API.Infrastructure
{
    public static class RegistrationServicesExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            //services.AddSingleton<IServiceBus, MassTransitServiceBus>();

            return services;
        }


    }
}