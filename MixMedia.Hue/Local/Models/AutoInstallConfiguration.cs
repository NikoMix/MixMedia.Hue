using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models
{
    public class AutoInstallConfiguration
    {
        /// <summary>
        /// Indicates if automatic update is activated. Default is false
        /// </summary>
        [JsonProperty("on")]
        public bool On { get; set; }

        /// <summary>
        /// T[hh]:[mm]:[ss] Local time of day.
        /// The bridge auto.updates for bridge and zigbee devices.The installation time will be randomized between updatetime and updatetime+T01:00:00. Default is T14:00:00.
        /// </summary>
        [JsonProperty("updatetime")]
        // TODO: Implement Trunctime Object
        public object UpdateTime { get; set; }

    }
}
