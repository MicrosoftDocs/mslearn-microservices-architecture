namespace DroneDelivery.Common.Models
{
    public class Location
    {
        public Location(double altitude, double latitude, double longitude)
        {
            Altitude = altitude;
            Latitude = latitude;
            Longitude = longitude;
        }
        public double Altitude { get; }
        public double Latitude { get; }
        public double Longitude { get; }
    }
}
