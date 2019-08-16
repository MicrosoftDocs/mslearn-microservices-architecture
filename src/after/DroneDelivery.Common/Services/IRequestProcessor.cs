using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery.Common.Services
{
    public interface IRequestProcessor
    {
        Task<bool> ProcessDeliveryRequestAsync(Delivery deliveryRequest);
    }
}
