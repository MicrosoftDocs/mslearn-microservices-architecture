using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery_after.Controllers
{
    public class HomeController : Controller
    {
        private const int RequestCount = 100;
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
        public IActionResult SendRequests()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var httpClient = httpClientFactory.CreateClient();
            var urlBuilder = new UriBuilder(this.Request.Scheme, this.Request.Host.Host);
            httpClient.BaseAddress = urlBuilder.Uri;

            var tasks = new Task[RequestCount];

            for (int i = 0; i < RequestCount; i++)
            {
                tasks[i] = httpClient.PostAsJsonAsync("/api/DeliveryRequests", payload);
            }

            Task.WaitAll(tasks);

            stopWatch.Stop();
            ViewBag.Message = $"{RequestCount} messages sent in {stopWatch.Elapsed.Seconds} seconds";
            return View();
        }
    }
}