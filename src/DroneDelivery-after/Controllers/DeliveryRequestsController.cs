using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DroneDelivery.Common.Models;
using DroneDelivery.Common.Services;

namespace DroneDelivery_after.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryRequestsController : ControllerBase
    {
        private readonly IRequestProcessor requestProcessor;
        private readonly ILogger<DeliveryRequestsController> logger;

        public DeliveryRequestsController(IRequestProcessor requestProcessor,
                                    ILogger<DeliveryRequestsController> logger)
        {
            this.requestProcessor = requestProcessor;
            this.logger = logger;
        }

        // PUT api/deliveries/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Delivery), 201)]
        public async Task<IActionResult> Put([FromBody]Delivery delivery, string id)
        {
            logger.LogInformation("In Put action with delivery {Id}: {Delivery}", id, delivery);

            var success = await requestProcessor.ProcessDeliveryRequestAsync(delivery);

            return CreatedAtRoute("GetDelivery", new { id = delivery.DeliveryId }, delivery);
        }
    }
}
