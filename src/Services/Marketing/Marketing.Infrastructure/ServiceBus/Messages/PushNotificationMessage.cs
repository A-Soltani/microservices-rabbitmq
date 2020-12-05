using MessageContract;

namespace Marketing.Infrastructure.ServiceBus.Messages
{
    public class SendPushNotification : ISendPushNotification
    {
        public string[] MobileNumbers { get; set; }
        public string PersianBody { get; set; }
        public string PersianTitle { get; set; }
        public string EnglishBody { get; set; }
        public string EnglishTitle { get; set; }
        public int SenderUserId { get; set; }
    }
}