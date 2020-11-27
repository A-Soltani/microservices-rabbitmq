using MediatR;

namespace Marketing.Application.Commands
{
    public class SendPushNotification: IRequest
    {
        public string[] MobileNumbers { get; set; }
        public string PersianBody { get; set; }
        public string PersianTitle { get; set; }
        public string EnglishBody { get; set; }
        public string EnglishTitle { get; set; }
        public int UserId { get; set; }
    }
}