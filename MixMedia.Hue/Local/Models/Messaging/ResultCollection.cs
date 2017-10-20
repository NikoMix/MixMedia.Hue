using System;
using System.Collections.Generic;
using System.Text;
using MixMedia.Hue.Local.Converters;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.Messaging
{
    [JsonConverter(typeof(ResultConverter))]
    public class ResultCollection : List<IResult>
    {
    }
}
