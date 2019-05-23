using System.Threading.Tasks;
using DroneDelivery.Common.Models;
using DroneDelivery.Common.Services;

namespace DroneDelivery_before.Services
{
    public class PackageProcessor : IPackageProcessor
    {
        public Task<PackageGen> CreatePackageAsync(PackageInfo packageInfo)
        {
            //Uses common data store e.g. SQL Azure tables
            Utility.DoWork(100);
            return Task.FromResult(new PackageGen { Id = packageInfo.PackageId });
        }
    }
}
