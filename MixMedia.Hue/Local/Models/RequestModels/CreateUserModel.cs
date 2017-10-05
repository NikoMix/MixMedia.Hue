using System;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local.Models.RequestModels
{

    [JsonObject]
    public class CreateUserModel
    {
        private string _deviceType;

        public CreateUserModel(string applicationName, string deviceName, string username = null)
        {
            DeviceType = $"{applicationName}#{deviceName}";
            Username = username;
        }

        [JsonRequired]
        [JsonProperty("devicetype")]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                if(!value.Contains("#"))
                    throw new ArgumentException(Messages.WrongDeviceTypeValue);

                if(value.Split('#')[0].Length > 20)
                    throw new ArgumentException(Messages.ApplicationNameTooBig);

                if (value.Split('#')[1].Length > 19)
                    throw new ArgumentException(Messages.DeviceNameTooBig);

              _deviceType = value;
            }
        }
        
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }
}
