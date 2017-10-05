using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.RequestModels
{
    public class RenameLightModel
    {
        /// <summary>
        /// The new name for the light. If the name is already taken a space and number will be appended by the bridge e.g. “Bedroom Light 1”.
        /// </summary>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
    }
}
