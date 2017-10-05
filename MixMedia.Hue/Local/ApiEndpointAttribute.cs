using System;

namespace MixMedia.Hue.Local
{
    public class ApiEndpointAttribute : Attribute
    {
        public ApiEndpointAttribute(string endpoint)
        {
            Endpoint = endpoint;
        }
        public string Endpoint { get; set; }

        public string Version { get; set; }
    }
}
