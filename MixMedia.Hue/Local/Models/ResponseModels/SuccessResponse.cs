using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.ResponseModels
{
    public class SuccessResponse<T> : IStatusResponse
    {
        [JsonProperty("success")]
        public T Success { get; set; }
    }
}
