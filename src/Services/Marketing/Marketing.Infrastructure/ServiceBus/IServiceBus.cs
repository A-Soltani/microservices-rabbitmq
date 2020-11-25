using System.Threading.Tasks;
using Marketing.Infrastructure.DTOs;

namespace Marketing.Infrastructure.ServiceBus
{
    public interface IServiceBus
    {
        Task Send(Notification notification);
    }
}