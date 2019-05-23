using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DroneDelivery.Common.Models
{
    public class PackageGen
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContainerSize Size { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
        [JsonProperty("weight")]
        public double Weight { get; set; }
    }
}
