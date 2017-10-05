using System;
using System.Collections.Generic;
using MixMedia.Hue.Local.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MixMedia.Hue.Local.Converters
{
    public class ValueCombinationConverter<T> : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var collection = new List<T>(2);
            if (value is ValueCombination<T> combination)
            {
                collection.Add(combination.X);
                collection.Add(combination.Y);
            }
            serializer.Serialize(writer, collection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            // Load JObject from stream
            JObject jObject = JObject.Load(reader);

            var xValue = jObject["x"].ToObject<T>();
            var yValue = jObject["y"].ToObject<T>();

            // Create target object based on JObject
            ValueCombination<T> target = new ValueCombination<T>() { X = xValue, Y = yValue};

            //Create a new reader for this jObject, and set all properties to match the original reader.
            JsonReader jObjectReader = jObject.CreateReader();
            jObjectReader.Culture = reader.Culture;
            jObjectReader.DateParseHandling = reader.DateParseHandling;
            jObjectReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
            jObjectReader.FloatParseHandling = reader.FloatParseHandling;

            // Populate the object properties
            serializer.Populate(jObjectReader, target);

            return target;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ValueCombination<T>);
        }
    }
}
