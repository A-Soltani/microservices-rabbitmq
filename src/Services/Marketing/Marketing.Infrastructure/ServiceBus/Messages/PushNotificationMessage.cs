using MessageContract;

namespace Marketing.Infrastructure.ServiceBus.Messages
{
    public class PushNotificationMessage: IPushNotificationMessage
    {
        public PushNotificationType NotificationType { get; set; }
        public string PersianBody { get; set; }
        public string PersianTitle { get; set; }
        public string EnglishBody { get; set; }
        public string EnglishTitle { get; set; }
        public string MobileNumber { get; set; }
        public int SenderUserId { get; set; }
    }
}