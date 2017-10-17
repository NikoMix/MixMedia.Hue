using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.ResponseModels
{
    public class ErrorResponse : IStatusResponse
    {
        [JsonProperty("error")]
        public HueError Error { get; set; }
    }
}
