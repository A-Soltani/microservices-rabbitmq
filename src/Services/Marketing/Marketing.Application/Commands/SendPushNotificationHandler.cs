using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Marketing.Infrastructure.ServiceBus;
using Marketing.Infrastructure.ServiceBus.Messages;
using MassTransit;
using MediatR;
using MessageContract;

namespace Marketing.Application.Commands
{
    public class SendPushNotificationHandler : AsyncRequestHandler<SendPushNotification>
    {
        private readonly IServiceBus _serviceBus;

        public SendPushNotificationHandler(IServiceBus serviceBus) => 
            _serviceBus = serviceBus ?? throw new ArgumentNullException(nameof(serviceBus));

        protected override async Task Handle(SendPushNotification sendPushNotification, CancellationToken cancellationToken)
        {
            for (var i = 0; i < sendPushNotification.MobileNumbers.Count(); i++)
            {
                var mobileNumber = sendPushNotification.MobileNumbers[i];
                var pushNotification = new PushNotificationMessage()
                {
                    NotificationType = PushNotificationType.MobileNo,
                    MobileNumber = mobileNumber,
                    EnglishBody = sendPushNotification.EnglishBody,
                    EnglishTitle = sendPushNotification.EnglishTitle,
                    PersianBody = sendPushNotification.PersianBody,
                    PersianTitle = sendPushNotification.PersianTitle,
                    SenderUserId = sendPushNotification.UserId
                };
                await _serviceBus.Send(pushNotification);
            }
        }
    }
}