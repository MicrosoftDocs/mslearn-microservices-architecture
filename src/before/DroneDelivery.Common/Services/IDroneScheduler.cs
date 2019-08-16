using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery.Common.Services
{
    public interface IDroneScheduler
    {
        Task<string> GetDroneIdAsync(Delivery deliveryRequest);
    }
}
