namespace PushNotifying.Infrastructure.Repositories.Dapper.PushNotification
{
    public class PushNotificationDto
    {
        public string AlertEn { get; set; }
        public string AlertFa { get; set; }
        public string PushTextEn { get; set; }
        public string PushTextFa { get; set; }
        public short ActionType { get; set; }
        public int UserId { get; set; }
        public string MobileNumber { get; set; }
        public long AppId { get; set; }

    }
}