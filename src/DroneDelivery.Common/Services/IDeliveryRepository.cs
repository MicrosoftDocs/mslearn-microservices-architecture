using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery.Common.Services
{
    public interface IDeliveryRepository
    {
        Task<Delivery> GetAsync(string id);
        Task<bool> ScheduleDeliveryAsync(Delivery deliveryRequest, string droneId);
    }
}
