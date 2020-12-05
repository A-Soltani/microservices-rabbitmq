using System.Threading;
using System.Threading.Tasks;
using Marketing.Infrastructure.ServiceBus.Messages;
using MessageContract;

namespace Marketing.Infrastructure.ServiceBus
{
    public interface IServiceBus
    {
        Task Send(ISendPushNotification pushNotification, CancellationToken cancellationToken);
    }
}