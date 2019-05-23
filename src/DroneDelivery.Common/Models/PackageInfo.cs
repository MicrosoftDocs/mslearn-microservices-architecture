﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DroneDelivery.Common.Models
{
    public class PackageInfo
    {
        [JsonProperty("packageId")]
        public string PackageId { get; set; }
        [JsonProperty("size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContainerSize Size { get; set; }
        [JsonProperty("weight")]
        public double Weight { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
