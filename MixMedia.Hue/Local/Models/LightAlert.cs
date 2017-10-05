using System.Runtime.Serialization;

namespace MixMedia.Hue.Local.Models
{
    /// <summary>
    /// The alert effect, is a temporary change to the bulb’s state
    /// </summary>
    /// <remarks>
    /// Note that this contains the last alert sent to the light and not its current state. i.e. After the breathe cycle has finished the bridge does not reset the alert to "none".
    /// </remarks>
    public enum LightAlert
    {
        /// <summary>
        ///  The light is not performing an alert effect.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// The light is performing one breathe cycle.
        /// </summary>
        [EnumMember(Value = "select")]
        Select,

        /// <summary>
        /// The light is performing breathe cycles for 15 seconds or until an "alert": "none" command is received.
        /// </summary>
        [EnumMember(Value = "lselect")]
        LSelect
    }
}
