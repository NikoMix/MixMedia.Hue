using System.Runtime.Serialization;

namespace MixMedia.Hue.Local.Models
{
    public enum InternetServiceState
    {
        [EnumMember(Value = "Connected")]
        Connected,

        [EnumMember(Value = "Disconnected")]
        Disconnected
    }
}
