using Marketing.Infrastructure.Repositories;
using Marketing.Infrastructure.ServiceBus;
using Microsoft.Extensions.DependencyInjection;

namespace Marketing.API.Infrastructure
{
    public static class RegistrationServicesExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IServiceBus, MassTransitServiceBus>();
            services.AddSingleton<ISqlConnectionProvider, SqlConnectionProvider>();

            return services;
        }


    }
}