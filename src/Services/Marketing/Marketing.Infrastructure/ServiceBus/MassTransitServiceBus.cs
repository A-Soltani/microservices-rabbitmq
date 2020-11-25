using System;
using System.Threading.Tasks;
using Marketing.Infrastructure.DTOs;
using MassTransit;

namespace Marketing.Infrastructure.ServiceBus
{
    public class MassTransitServiceBus : IServiceBus
    {
        private readonly IBusControl _busControl;

        public MassTransitServiceBus(IBusControl busControl) 
            => _busControl = busControl ?? throw new ArgumentNullException(nameof(busControl));

        public async Task Send(Notification notification)
        {
            await _busControl.Send(notification);
        }
    }
}