using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.Hue.Local
{
    public class Rules
    {
        private HttpClient client;
        private ServiceSettings settings;

        public Rules(HttpClient client, ServiceSettings settings)
        {
            this.client = client;
            this.settings = settings;
        }

        public async void GetAllRules()
        {
            await client.GetAsync($"/api/{settings.Username}/rules");
        }

        public async void GetRule(string id)
        {
            await client.GetAsync($"/api/{settings.Username}/rules/{id}");
        }

        public async void CreateRule()
        {
            await client.PostAsync($"/api/{settings.Username}/rules", new StringContent(""));
        }

        public async void UpdateRule(string id)
        {
            await client.PutAsync($"/api/{settings.Username}/rules/{id}", new StringContent(""));
        }

        public async void DeleteRule(string id)
        {
            await client.DeleteAsync($"/api/{settings.Username}/rules/{id}");
        }
    }
}
