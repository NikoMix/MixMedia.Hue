using System;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models
{
    public class LightState
    {
        [JsonProperty("on")]
        public bool On { get; set; }

        [JsonProperty("bri")]
        public byte Brightness { get; set; }

        [JsonProperty("hue")]
        public UInt16 Hue { get; set; }

        [JsonProperty("sat")]
        public byte Saturation { get; set; }

        [JsonProperty("xy", ItemConverterType = typeof(ValueCombination<float>))]
        public ValueCombination<float> XyColorSpaceCoordinates { get; set; }
    }
}
