namespace PushNotifying.Domain.AggregatesModel.NotificationAggregate.NotificationMessages
{
    public class PersianNotificationMessage : INotificationMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}