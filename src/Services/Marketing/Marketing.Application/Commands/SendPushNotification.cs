using MediatR;
using MessageContract;

namespace Marketing.Application.Commands
{
    public class SendPushNotification: IRequest, ISendPushNotification
    {
        public string[] MobileNumbers { get; set; }
        public string PersianBody { get; set; }
        public string PersianTitle { get; set; }
        public string EnglishBody { get; set; }
        public string EnglishTitle { get; set; }
        public int SenderUserId { get; set; }
    }
}