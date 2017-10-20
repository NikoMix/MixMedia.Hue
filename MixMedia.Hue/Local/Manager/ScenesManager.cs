using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.Hue.Local.Manager
{
    public class ScenesManager
    {
        private HttpClient client;
        private ServiceSettings settings;

        public ScenesManager(HttpClient client, ServiceSettings settings)
        {
            this.client = client;
            this.settings = settings;
        }

        public async void GetAllScenes()
        {
            await client.GetAsync($"/api/{settings.Username}/scenes");
        }

        public async void CreateScene()
        {
            await client.PostAsync($"/api/{settings.Username}/scenes/", new StringContent(""));
        }

        public async void ModifyScene(string id, string stateId)
        {
            await client.PutAsync($"/api/{settings.Username}/scenes/{id}/lightstates/<id>", new StringContent(""));
        }

        public async void RecallScene()
        {
            // uses GroupManager
        }

        public async void DeleteScene(string id)
        {
            await client.DeleteAsync($"/api/{settings.Username}/scenes/{id}");
        }

        public async void GetScene(string id)
        {
            await client.GetAsync($"/api/{settings.Username}/scenes/{id}");
        }
    }
}
