using MediatR;

namespace PushNotifying.Application.Commands
{
    public class SendPushNotification: IRequest
    {
        public string MobileNumber { get; set; }
        public string PersianBody { get; set; }
        public string PersianTitle { get; set; }
        public string EnglishBody { get; set; }
        public string EnglishTitle { get; set; }
        public int UserId { get; set; }
    }
}