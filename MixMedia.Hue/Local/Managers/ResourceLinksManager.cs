using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.Hue.Local.Manager
{
    public class ResourceLinksManager
    {
        private HttpClient client;
        private ServiceSettings settings;

        public ResourceLinksManager(HttpClient client, ServiceSettings settings)
        {
            this.client = client;
            this.settings = settings;
        }

        public async void GetAllResourceLinks()
        {
            await client.GetAsync($"/api/{settings.Username}/resourcelinks");
        }

        public async void GetResourceLink(string id)
        {
            await client.GetAsync($"/api/{settings.Username}/resourcelinks/{id}");
        }

        public async void CreateResourceLink()
        {
            await client.PostAsync($"/api/{settings.Username}/resourcelinks", new StringContent(""));
        }

        public async void UpdateResourcelink(string id)
        {
            await client.PutAsync($"/api/{settings.Username}/resourcelinks/{id}", new StringContent(""));
        }

        public async void DeleteResourceLink(string id)
        {
            await client.DeleteAsync($"/api/{settings.Username}/resourcelinks/{id}");
        }
    }
}
