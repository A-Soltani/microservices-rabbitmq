﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Marketing.Infrastructure.ServiceBus.Messages;
using MassTransit;
using MessageContract;

namespace Marketing.Infrastructure.ServiceBus
{
    public class MassTransitServiceBus : IServiceBus
    {
        readonly IPublishEndpoint _publishEndpoint;

        public MassTransitServiceBus(IPublishEndpoint publishEndpoint) => 
            _publishEndpoint = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));


        public async Task Send(ISendPushNotification pushNotification, CancellationToken cancellationToken)
        {
            await _publishEndpoint.Publish(pushNotification, cancellationToken);
        }
    }
}