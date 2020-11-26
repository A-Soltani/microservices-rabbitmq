namespace PushNotifying.Domain.AggregatesModel.NotificationAggregate.NotificationMessages
{
    public class EnglishNotificationMessage : INotificationMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}