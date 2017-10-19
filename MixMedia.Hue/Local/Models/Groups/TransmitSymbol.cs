using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.Groups
{
    public class TransmitSymbol
    {
        [JsonProperty("duration")]
        public UInt16 Duration { get; set; }

        [JsonProperty("symbolselection")]
        public string SymbolSelection { get; set; }
    }
}
