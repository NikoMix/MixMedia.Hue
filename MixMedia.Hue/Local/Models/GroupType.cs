using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MixMedia.Hue.Local.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupType
    {
        /// <summary>
        /// Multisource luminaire group A lighting installation of default groupings of hue lights. The bridge will pre-install these groups for ease of use. This type cannot be created manually.  Also, a light can only be in a maximum of one luminaire group. See multisource luminaires for more info.
        /// </summary>
        [EnumMember(Value = "Luminaire")]
        Luminaire,

        /// <summary>
        /// LightSource group A sub group of multisource luminaire lights that are typically separate sections of a multisource luminaires. This type cannot be created manually.  Also, a light can only be in a maximum of one lightsource group. See multisource luminaires for more info.
        /// </summary>
        [EnumMember(Value = "Lightsource")]
        Lightsource,

        /// <summary>
        /// LightGroup group A group of lights that can be controlled together. This the default group type that the bridge generates for user created groups. Default type when no type is given on creation.
        /// </summary>
        [EnumMember(Value = "LightGroup")]
        LightGroup,

        /// <summary>
        /// Room A group of lights that are physically located in the same place in the house. Rooms behave similar as light groups, except: 
        /// -   (1) A room can be empty and contain 0 lights, 
        /// -   (2) a light is only allowed in one room and 
        /// -   (3) a room isn't automatically deleted when all lights in that room are deleted.
        /// </summary>
        [EnumMember(Value = "Room")]
        Room
    }
}
