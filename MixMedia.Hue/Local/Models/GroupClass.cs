using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MixMedia.Hue.Local.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupClass
    {
        [EnumMember(Value = "Living room")]
        LivingRoom,

        [EnumMember(Value = "Kitchen")]
        Kitchen,

        [EnumMember(Value = "Dining")]
        Dining,

        [EnumMember(Value = "Bedroom")]
        Bedroom,

        [EnumMember(Value = "Kids bedroom")]
        KidsBedroom,

        [EnumMember(Value = "Bathroom")]
        Bathroom,

        [EnumMember(Value = "Nursery")]
        Nursery,

        [EnumMember(Value = "Recreation")]
        Recreation,

        [EnumMember(Value = "Office")]
        Office,

        [EnumMember(Value = "Gym")]
        Gym,

        [EnumMember(Value = "Hallway")]
        Hallway,

        [EnumMember(Value = "Toilet")]
        Toilet,

        [EnumMember(Value = "Front door")]
        FrontDoor,

        [EnumMember(Value = "Garage")]
        Garage,

        [EnumMember(Value = "Terrace")]
        Terrace,

        [EnumMember(Value = "Garden")]
        Garden,

        [EnumMember(Value = "Driveway")]
        Driveway,

        [EnumMember(Value = "Carport")]
        Carport,

        [EnumMember(Value = "Other")]
        Other
    }
}
