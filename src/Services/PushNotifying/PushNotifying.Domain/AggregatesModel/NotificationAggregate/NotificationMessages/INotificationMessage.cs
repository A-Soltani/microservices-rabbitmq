namespace PushNotifying.Domain.AggregatesModel.NotificationAggregate.NotificationMessages
{
    public interface INotificationMessage
    {
        string Subject { get; set; }
        string Body { get; set; }
    }
}