using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery.Common.Services
{
    public interface IPackageProcessor
    {
        Task<PackageGen> CreatePackageAsync(PackageInfo packageInfo);
    }
}
