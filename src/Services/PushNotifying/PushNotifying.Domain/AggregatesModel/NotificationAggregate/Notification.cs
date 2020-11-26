using PushNotifying.Domain.AggregatesModel.NotificationAggregate.NotificationMessages;

namespace PushNotifying.Domain.AggregatesModel.NotificationAggregate
{
    public class Notification
    {
        public EnglishNotificationMessage EnglishMessage { get; set; }
        public PersianNotificationMessage PersianMessage { get; set; }
    }
}