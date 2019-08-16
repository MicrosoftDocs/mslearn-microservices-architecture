using System;

namespace DroneDelivery.Common.Models
{
    public class Delivery
    {
        public string DeliveryId { get; set; }
        public string OwnerId { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public string Deadline { get; set; }
        public bool Expedited { get; set; }
        public ConfirmationRequired ConfirmationRequired { get; set; }
        public DateTime PickupTime { get; set; }
        public PackageInfo PackageInfo { get; set; }

    }
}
