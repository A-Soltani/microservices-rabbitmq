using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using MessageContract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Marketing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PushNotificationController : ControllerBase
    {
        private readonly IBusControl _busControl;
        readonly IPublishEndpoint _publishEndpoint;


        public PushNotificationController(IBusControl busControl, IPublishEndpoint publishEndpoint)
        {
            _busControl = busControl ?? throw new ArgumentNullException(nameof(busControl));
            _publishEndpoint = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));
        }

        [HttpPost]
        public async Task<ActionResult> Publish([FromBody] PushNotificationUploaded pushNotification)
        {
            //var uri = new Uri("rabbitmq://localhost/order-service");
            //var uri = new Uri("exchange:order-service");

            //var endpoint = await _busControl.GetSendEndpoint(uri);
            //await endpoint.Send(pushNotification);
            await _publishEndpoint.Publish(pushNotification);
            return Ok();
        }
    }


}