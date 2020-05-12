using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace TempProject
{

    [JsonObject(MemberSerialization.OptIn)]
    public class InputConfiguration
    {
        [JsonProperty(PropertyName = "VehicleConfiguration")]
        public List<VehicleConfiguration> VehicleConfiguration { get; set; }
    }
}

