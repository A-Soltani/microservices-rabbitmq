namespace Marketing.Infrastructure.DTOs
{
    public class Notification
    {
		public short NotificationFileType { get; set; }
        public string DestinationNumber { get; set; }
        public string PersianBody { get; set; }
        public string PersianTitle { get; set; }
        public string EnglishBody { get; set; }
        public string EnglishTitle { get; set; }
        public int UserId { get; set; }
	}
}