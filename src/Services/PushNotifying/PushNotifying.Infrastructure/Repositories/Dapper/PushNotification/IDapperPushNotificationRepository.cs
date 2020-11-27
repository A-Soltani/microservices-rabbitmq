using System.Threading.Tasks;

namespace PushNotifying.Infrastructure.Repositories.Dapper.PushNotification
{
    public interface IDapperPushNotificationRepository
    {
        Task Add(PushNotificationDto pushNotificationDto);
    }
}