namespace MessageContract
{
    public interface ISendPushNotification
    {
        string[] MobileNumbers { get; set; }
        string PersianBody { get; set; }
        string PersianTitle { get; set; }
        string EnglishBody { get; set; }
        string EnglishTitle { get; set; }
        int SenderUserId { get; set; }
    }
}