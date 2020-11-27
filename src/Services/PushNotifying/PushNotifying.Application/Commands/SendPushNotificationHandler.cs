using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MessageContract;
using PushNotifying.Infrastructure.Repositories.Dapper.PushNotification;

namespace PushNotifying.Application.Commands
{
    public class SendPushNotificationHandler : AsyncRequestHandler<SendPushNotification>
    {
        private readonly IDapperPushNotificationRepository _dapperPushNotificationRepository;

        public SendPushNotificationHandler(IDapperPushNotificationRepository dapperPushNotificationRepository) =>
            _dapperPushNotificationRepository = dapperPushNotificationRepository ?? throw new ArgumentNullException(nameof(dapperPushNotificationRepository));

        protected override async Task Handle(SendPushNotification sendPushNotification, CancellationToken cancellationToken)
        {
            var pushNotificationDto = new PushNotificationDto()
            {
                ActionType = (short)PushNotificationType.MobileNo,
                MobileNumber = sendPushNotification.MobileNumber,
                PushTextEn = sendPushNotification.EnglishBody,
                AlertEn = sendPushNotification.EnglishTitle,
                PushTextFa = sendPushNotification.PersianBody,
                AlertFa = sendPushNotification.PersianTitle,
                UserId = sendPushNotification.UserId
            };
            await _dapperPushNotificationRepository.Add(pushNotificationDto);
        }
    }
}