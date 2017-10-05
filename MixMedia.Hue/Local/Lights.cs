using System;
using System.Net.Http;
using System.Text;
using MixMedia.Hue.Local.Models;
using MixMedia.Hue.Local.Models.RequestModels;
using Newtonsoft.Json;

namespace MixMedia.Hue.Local
{
    public class Lights
    {
        private HttpClient client;
        private ServiceSettings settings;

        public Lights(HttpClient client, ServiceSettings settings)
        {
            this.client = client;
            this.settings = settings;
        }

        // TODO: Implement return Object
        public async void GetAllLights()
        {
            await client.GetAsync($"/api/{settings.Username}/lights");
        }

        // TODO: Implement return Object
        public async void GetNewLights()
        {
            await client.GetAsync($"/api/{settings.Username}/lights/new");
        }

        // TODO: Implement return Object + Search Object
        public async void SearchLights()
        {
            await client.PostAsync($"/api/{settings.Username}/lights", new StringContent(String.Empty));
        }

        public async void GetLight()
        {
            
        }

        // TODO: Implement return Object
        public async void RenameLight(string id, string name)
        {
            var content = JsonConvert.SerializeObject(new RenameLightModel {Name = name});
            await client.PutAsync($"/api/{settings.Username}/lights/{id}", new StringContent(content, Encoding.UTF8));
        }

        // TODO: Implement return Object
        public async void SetLightState(string id, LightState state)
        {
            var content = JsonConvert.SerializeObject(state);
            await client.PutAsync($"/api/{settings.Username}/lights/state", new StringContent(content, Encoding.UTF8));
        }

        public async void DeleteLight(string id)
        {
            await client.DeleteAsync($"/api/{settings.Username}/lights/{id}");
        }
    }
}
