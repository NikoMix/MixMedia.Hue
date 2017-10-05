using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models
{
    public class Light
    {
        /// <summary>
        /// Details the state of the light, see the state table below for more details.
        /// </summary>
        [JsonProperty("state")]
        public object State { get; set; }

        /// <summary>
        /// A fixed name describing the type of light e.g. “Extended color light”.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A unique, editable name given to the light.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The hardware model of the light.
        /// </summary>
        [JsonProperty("modelid")]
        public string ModelId { get; set; }

        /// <summary>
        /// As of 1.4. Unique id of the device. The MAC address of the device with a unique endpoint id in the form: AA:BB:CC:DD:EE:FF:00:11-XX
        /// </summary>
        [JsonProperty("uniqueid")]
        public string UniqueId { get; set; }

        /// <summary>
        /// As of 1.7. The manufacturer name.
        /// </summary>
        [JsonProperty("manufacturername")]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// As of 1.9. Unique ID of the luminaire the light is a part of in the format: AA:BB:CC:DD-XX-YY.  AA:BB:, ... represents the hex of the luminaireid, XX the lightsource position (incremental but may contain gaps) and YY the lightpoint position (index of light in luminaire group).  A gap in the lightpoint position indicates an incomplete luminaire (light search required to discover missing light points in this case).
        /// </summary>
        [JsonProperty("luminaireuniqueid")]
        public string LuminaireUniqueId { get; set; }

        /// <summary>
        /// An identifier for the software version running on the light.
        /// </summary>
        [JsonProperty("swversion")]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// This parameter is reserved for future functionality. As from 1.11 point symbols are no longer returned.
        /// </summary>
        [JsonProperty("pointsymbol")]
        public object PointSymbol { get; set; }
    }
}
