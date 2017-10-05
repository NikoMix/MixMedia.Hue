using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.ResponseModels
{
    public class CreateUserResponse
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
