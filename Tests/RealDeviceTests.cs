using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MixMedia.Hue.Local;
using MixMedia.Hue.Local.Manager;
using Xunit;

namespace MixMedia.Hue.Tests
{
    public class RealDeviceTests
    {
        private readonly HttpClient client;
        private readonly ServiceSettings settings;
        
        public RealDeviceTests()
        {
            client = new HttpClient();
            settings = new ServiceSettings(){ ApplicationName = "UnitTest", DeviceName = "TestRunner"};
        }

        [Fact]
        public async Task RegisterUserWithBridgeAsync()
        {
            var config = new ConfigurationManager(client, settings);
            var result = await config.CreateUser(settings.ApplicationName, settings.DeviceName);
            
           Assert.NotNull(result);

        }

    }
}
