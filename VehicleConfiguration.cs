using Newtonsoft.Json;

namespace TempProject
{
    [JsonObject(MemberSerialization.OptIn)]
    public class VehicleConfiguration
    {
        [JsonProperty(PropertyName = "VehicleUniqueID")]
        public int VehicleUniqueID { get; set; }

        [JsonProperty(PropertyName = "VehicleRegistrationPlate")]
        public string VehicleRegistrationPlate { get; set; }

        [JsonProperty(PropertyName = "VehicleType")]
        public int VehicleType { get; set; }

        [JsonProperty(PropertyName = "VehicleGrossWeight")]
        public int VehicleGrossWeight { get; set; }

        [JsonProperty(PropertyName = "VehicleTare")]
        public int VehicleTare { get; set; }

        [JsonProperty(PropertyName = "VehicleStart")]
        public string VehicleStart { get; set; }

        [JsonProperty(PropertyName = "VehicleEnd")]
        public string VehicleEnd { get; set; }

        [JsonProperty(PropertyName = "MaxStops")]
        public int MaxStops { get; set; }
    }
}
