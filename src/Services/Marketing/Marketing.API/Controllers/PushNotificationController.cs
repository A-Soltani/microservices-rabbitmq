using System;
using System.Threading.Tasks;
using Marketing.Application.Commands;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Marketing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PushNotificationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PushNotificationController(IMediator mediator) =>
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<ActionResult> Send([FromBody] SendPushNotification sendPushNotification)
        {
            await _mediator.Send(sendPushNotification);
            return Ok();
        }

    }


}