using System;
using System.Threading;
using System.Threading.Tasks;
using Marketing.Infrastructure.ServiceBus.Messages;
using MassTransit;

namespace Marketing.Infrastructure.ServiceBus
{
    public class MassTransitServiceBus : IServiceBus
    {
        readonly IPublishEndpoint _publishEndpoint;

        public MassTransitServiceBus(IPublishEndpoint publishEndpoint) => 
            _publishEndpoint = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));


        public async Task Send(PushNotificationMessage pushNotification)
        {
            var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            await _publishEndpoint.Publish(pushNotification, tokenSource.Token);
        }
    }
}