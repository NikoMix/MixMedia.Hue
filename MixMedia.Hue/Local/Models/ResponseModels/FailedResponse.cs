using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.ResponseModels
{
    public class FailedResponse<T> : IStatusResponse
    {
        [JsonProperty("error")]
        public T Error { get; set; }
    }
}
