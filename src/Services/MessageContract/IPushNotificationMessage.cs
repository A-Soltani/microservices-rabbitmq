namespace MessageContract
{
    public interface IPushNotificationMessage
    {
        PushNotificationType NotificationType { get; set; }
        string PersianBody { get; set; }
        string PersianTitle { get; set; }
        string EnglishBody { get; set; }
        string EnglishTitle { get; set; }
        string MobileNumber { get; set; }
        int SenderUserId { get; set; }
    }
}
