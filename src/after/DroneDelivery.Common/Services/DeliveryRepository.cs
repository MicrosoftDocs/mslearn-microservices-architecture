using System;
using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery.Common.Services
{
    public class DeliveryRepository : IDeliveryRepository
    {
        public Task<Delivery> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ScheduleDeliveryAsync(Delivery deliveryRequest, string droneId)
        {
            //Access common datastore e.g. SQL Azure
            Utility.DoWork(50);
            return Task.FromResult(true);
        }
    }
}
