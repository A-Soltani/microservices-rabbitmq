using System.Threading;
using System.Threading.Tasks;
using Marketing.Infrastructure.ServiceBus.Messages;

namespace Marketing.Infrastructure.ServiceBus
{
    public interface IServiceBus
    {
        Task Send(PushNotificationMessage pushNotification, CancellationToken cancellationToken);
    }
}