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

        // POST api/deliveries
        [HttpPost()]
        [ProducesResponseType(typeof(Delivery), 201)]
        public async Task<IActionResult> Post([FromBody]Delivery delivery)
        {
            logger.LogInformation("In Post action: {Delivery}", delivery);

            var success = await requestProcessor.ProcessDeliveryRequestAsync(delivery);

            return CreatedAtRoute("GetDelivery", new { id = delivery.DeliveryId }, delivery);
        }
    }
}
