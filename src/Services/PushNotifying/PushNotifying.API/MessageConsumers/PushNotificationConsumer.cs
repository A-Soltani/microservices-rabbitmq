using System;
using System.Threading.Tasks;
using MassTransit;
using MediatR;
using MessageContract;
using PushNotifying.Application.Commands;

namespace PushNotifying.API.MessageConsumers
{
    public abstract class PushNotificationConsumer : IConsumer<IPushNotificationMessage>
    {
        private readonly IMediator _mediator;

        protected PushNotificationConsumer(IMediator mediator) => 
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        public async Task Consume(ConsumeContext<IPushNotificationMessage> context)
        {
            var pushNotificationMessage = context.Message;
            var sendPushNotification = new SendPushNotification()
            {
                PersianTitle = pushNotificationMessage.PersianTitle,
                PersianBody = pushNotificationMessage.PersianBody,
                UserId = pushNotificationMessage.SenderUserId,
                EnglishBody = pushNotificationMessage.EnglishBody,
                EnglishTitle = pushNotificationMessage.EnglishTitle,
                MobileNumber = pushNotificationMessage.MobileNumber
            };
            await _mediator.Send(sendPushNotification);
        }
    }
}