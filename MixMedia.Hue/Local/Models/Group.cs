using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models
{
    public class Group
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("type", Required = Required.AllowNull)]
        public string Type { get; set; }

        [JsonProperty("lights")]
        public List<string> Lights { get; set; }

        [JsonProperty("action", Required = Required.AllowNull)]
        public object Action { get; set; }

        [JsonProperty("state", Required = Required.AllowNull)]
        public object State { get; set; }

        [JsonProperty("recycle")]
        public bool Recycle { get; set; }
    }
}
