using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.Groups
{
    public class State
    {
        [JsonProperty("any_on")]
        public bool AnyOn { get; set; }

        [JsonProperty("any_off")]
        public bool AnyOff { get; set; }
    }
}
