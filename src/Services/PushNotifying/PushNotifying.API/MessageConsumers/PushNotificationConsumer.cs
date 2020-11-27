using System.Threading.Tasks;
using MassTransit;
using MessageContract;

namespace PushNotifying.API.MessageConsumers
{
    public abstract class PushNotificationConsumer : IConsumer<IPushNotificationMessage>
    {
        public Task Consume(ConsumeContext<IPushNotificationMessage> context)
        {
            var message = context.Message;
            return Task.FromResult(message);
        }
    }
}