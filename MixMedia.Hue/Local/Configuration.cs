using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.Hue.Local.Models.RequestModels;
using MixMedia.Hue.Local.Models.ResponseModels;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local
{
    [ApiEndpoint("/api")]
    public class Configuration
    {
        private readonly HttpClient client;
        public Configuration(HttpClient client)
        {
             this.client = client;
            client.BaseAddress = new Uri("http://192.168.0.12");
        }

        public async Task<List<SuccessResponse<CreateUserResponse>>> CreateUser(string applicationName, string deviceName)
        {
            //Task.WaitAll(Task.Run(() =>
            //{
            var model = new CreateUserModel(applicationName, deviceName);
            var message = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8);
            //}), TimeSpan.FromSeconds(30));
            var response = await client.PostAsync("/api", message);
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<SuccessResponse<CreateUserResponse>>>(responseString);
        }

        public async Task GetConfiguration()
        {
            
        }

        public async void DeleteUser(string username)
        {
            // Todo: Insert User
            var user = "";
            await client.DeleteAsync($"/api/{user}/config/Whitelist/{username}");
        }

    }
}
