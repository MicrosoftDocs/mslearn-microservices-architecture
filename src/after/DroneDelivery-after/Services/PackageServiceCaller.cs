using System.Net.Http;
using System.Threading.Tasks;
using DroneDelivery.Common.Models;
using DroneDelivery.Common.Services;

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
            var result = await httpClient.PutAsJsonAsync($"{packageInfo.PackageId}?code={FunctionCode}", packageInfo);
            result.EnsureSuccessStatusCode();

            return new PackageGen { Id = packageInfo.PackageId };
        }
    }
}
