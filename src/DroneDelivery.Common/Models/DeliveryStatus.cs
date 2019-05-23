namespace DroneDelivery.Common.Models
{
    public class DeliveryStatus
    {
        public DeliveryStatus(DeliveryStage deliveryStage, Location lastKnownLocation, string pickupeta, string deliveryeta)
        {
            Stage = deliveryStage;
            LastKnownLocation = lastKnownLocation;
            PickupETA = pickupeta;
            DeliveryETA = deliveryeta;
        }
        public DeliveryStage Stage { get; }
        public Location LastKnownLocation { get; }
        public string PickupETA { get; }
        public string DeliveryETA { get; }
    }
}
