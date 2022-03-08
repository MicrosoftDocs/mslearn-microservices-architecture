using System.Net.Http;
using System.Threading.Tasks;
using DroneDelivery.Common.Models;
using DroneDelivery.Common.Services;
using Newtonsoft.Json;

namespace DroneDelivery_after.Services
{
    public class PackageServiceCaller : IPackageProcessor
    {
        private readonly HttpClient httpClient;

        public static string FunctionCode { get; set; }

        public PackageServiceCaller(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<PackageGen> CreatePackageAsync(PackageInfo packageInfo)
        {
            string jsonString = JsonConvert.SerializeObject(packageInfo);

            var httpContent = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");

            var result = await httpClient.PostAsync($"{packageInfo.PackageId}?code={FunctionCode}", httpContent);
            result.EnsureSuccessStatusCode();

            return new PackageGen { Id = packageInfo.PackageId };
        }
    }
}
