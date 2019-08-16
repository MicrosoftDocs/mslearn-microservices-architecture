using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery.Common.Services
{
    public class DroneScheduler : IDroneScheduler
    {
        public Task<string> GetDroneIdAsync(Delivery deliveryRequest)
        {
            //Access common data store e.g. SQL Azure
            Utility.DoWork(50);
            return Task.FromResult("test-drone-id");
        }
    }
}
