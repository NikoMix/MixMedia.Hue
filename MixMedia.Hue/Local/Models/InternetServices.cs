using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models
{
    public class InternetServices
    {
        /// <summary>
        /// Indicates if a Bridge has a connection to Internet.
        /// </summary>
        [JsonProperty("internet")]
        public InternetServiceState Internet { get; set; }

        /// <summary>
        /// If remote CLIP is available.
        /// If remoteaccess is unavailable, reasons can be portalservices are false or no remote connection is available.
        /// </summary>
        [JsonProperty("internet")]
        public InternetServiceState RemoteAccess { get; set; }

        /// <summary>
        /// Time was synchronized with internet service.
        /// Internet time service was not reachable for 48hrs.
        /// </summary>
        [JsonProperty("internet")]
        public InternetServiceState TimeSync { get; set; }

        /// <summary>
        /// swupdate server is available.
        /// swupdate server was not reachable in the last 24 hrs.
        /// </summary>
        [JsonProperty("internet")]
        public InternetServiceState SoftwareUpdate { get; set; }
    }
}
