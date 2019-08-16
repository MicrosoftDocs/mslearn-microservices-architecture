using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DroneDelivery_before.Controllers
{
    public class HomeController : Controller
    {
        private const int RequestCount = 1000;
        private readonly HttpClient httpClient;
        private string payload;

        public HomeController(HttpClient httpClient)
        {
            this.httpClient = httpClient;

            this.payload = @"{
              ""deliveryId"": ""delivery123"",
              ""ownerId"": ""string"",
              ""pickupLocation"": ""string"",
              ""dropoffLocation"": ""string"",
              ""pickupTime"": ""2019-05-28T20:21:21.240Z"",
              ""deadline"": ""string"",
              ""expedited"": true,
              ""confirmationRequired"": 0,
              ""packageInfo"": {
                            ""packageId"": ""package1234567"",
                ""containerSize"": 0,
                ""weight"": 0,
                ""tag"": ""string""
              }
            }";
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        [Route("/[controller]/SendRequests")]
        public async Task<IActionResult> SendRequests()
        {
            var urlBuilder = new UriBuilder(this.Request.Scheme, this.Request.Host.Host);
            urlBuilder.Path = "api/DeliveryRequests?subscription-key=2ba32e67aab041aca4fb9e33e956a1c6";

            for (int i = 0; i < RequestCount; i++)
            {
                var response = await httpClient.PostAsync(urlBuilder.Uri.ToString(), new StringContent(payload));
            }
            return View();
        }
    }
}