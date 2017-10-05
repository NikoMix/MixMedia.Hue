using System;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.RequestModels
{
    public class ModifyBridgeConfigurationModel
    {
        [JsonProperty("proxyport")]
        public UInt16 ProxyPort { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("swupdate")]
        public UpdateInformation SoftwareUpdate { get; set; }
    }
}
