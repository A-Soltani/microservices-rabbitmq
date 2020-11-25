using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Marketing.Infrastructure.DTOs;
using Marketing.Infrastructure.ServiceBus;
using MassTransit;
using MediatR;
using MessageContract;

namespace Marketing.Application.Commands
{
    public class SendPushNotificationHandler : AsyncRequestHandler<SendPushNotification>
    {
        readonly IPublishEndpoint _publishEndpoint;

        public SendPushNotificationHandler(IPublishEndpoint publishEndpoint) 
            => _publishEndpoint = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));

        protected override async Task Handle(SendPushNotification sendPushNotification, CancellationToken cancellationToken)
        {
            for (var i = 0; i < sendPushNotification.MobileNumbers.Count(); i++)
            {
                var mobileNumber = sendPushNotification.MobileNumbers[i];
                var notification = new PushNotification()
                {
                    DestinationNumber = mobileNumber,
                    EnglishBody = sendPushNotification.EnglishBody,
                    EnglishTitle = sendPushNotification.EnglishTitle,
                    NotificationFileType = sendPushNotification.NotificationFileType,
                    PersianBody = sendPushNotification.PersianBody,
                    PersianTitle = sendPushNotification.PersianTitle,
                    UserId = sendPushNotification.UserId
                };
                var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(10));
                await _publishEndpoint.Publish(notification, tokenSource.Token);
            }
        }
    }
}