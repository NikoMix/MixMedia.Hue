using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.Hue.Local.Models.RequestModels;
using MixMedia.Hue.Local.Models.ResponseModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MixMedia.Hue.Local.Manager
{
    public class ConfigurationManager
    {
        private readonly HttpClient client;
        private readonly ServiceSettings settings;
        public ConfigurationManager(HttpClient client, ServiceSettings settings)
        {
            this.client = client;
            client.BaseAddress = new Uri("http://192.168.0.12");
            this.settings = settings;
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

            JArray responseCollection = JArray.Parse(responseString);

           
            List<IStatusResponse> responseValues = JsonConvert.DeserializeObject<List<IStatusResponse>>(responseString, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore });


            //var question = JsonConvert.DeserializeObject <>(responseValues[0].ToString());

            return JsonConvert.DeserializeObject<List<SuccessResponse<CreateUserResponse>>>(responseString);
        }

        public async Task GetConfiguration()
        {
            await client.GetAsync($"/api/{settings.Username}/config");
        }

        public async void ModifyConfiguration()
        {
            await client.PutAsync($"/api/{settings.Username}/config", new StringContent(""));
        }

        public async void DeleteUser(string username)
        {
            await client.DeleteAsync($"/api{settings.Username}/config/Whitelist/{username}");
        }

        public async void GetFullState()
        {
            await client.GetAsync($"/api/{settings.Username}");
        }
    }
}
