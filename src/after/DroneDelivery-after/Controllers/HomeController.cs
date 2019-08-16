using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery_after.Controllers
{
    public class HomeController : Controller
    {
        private const int RequestCount = 1000;
        private readonly IHttpClientFactory httpClientFactory;
        private Delivery payload;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;

            this.payload = new Delivery()
            {
                DeliveryId = "delivery123",
                OwnerId = "owner123",
                PickupLocation = "pickup",
                DropoffLocation = "dropoff",
                PickupTime = DateTime.Now.AddDays(3),
                Deadline = "deadline",
                Expedited = true,
                ConfirmationRequired = ConfirmationRequired.None,
                PackageInfo = new PackageInfo()
                {
                    PackageId = "package1234567",
                    Size = ContainerSize.Small,
                    Weight = 0,
                    Tag = "tag"
                }
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        [Route("/[controller]/SendRequests")]
        public async Task<IActionResult> SendRequests()
        {
            var httpClient = httpClientFactory.CreateClient();
            var urlBuilder = new UriBuilder(this.Request.Scheme, this.Request.Host.Host);
            httpClient.BaseAddress = urlBuilder.Uri;

            for (int i = 0; i < RequestCount; i++)
            {
                var response = await httpClient.PostAsJsonAsync("/api/DeliveryRequests?subscription-key=2ba32e67aab041aca4fb9e33e956a1c6", payload);
            }
            return View();
        }
    }
}