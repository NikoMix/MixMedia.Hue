using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.Hue.Local.Manager
{
    public class SensorsManager
    {
        private HttpClient client;
        private ServiceSettings settings;

        public SensorsManager(HttpClient client, ServiceSettings settings)
        {
            this.client = client;
            this.settings = settings;
        }

        public async void GetAllSensors()
        {
            await client.GetAsync($"/api/{settings.Username}/sensors");
        }

        public async void CreateSensor()
        {
            await client.PostAsync($"/api/{settings.Username}/sensors", new StringContent(""));
        }

        public async void FindNewSensors()
        {
            await client.PostAsync($"/api/{settings.Username}/sensors", new StringContent(""));
        }

        public async void GetNewSensors()
        {
            await client.GetAsync($"/api/{settings.Username}/sensors/new");
        }

        public async void GetSensor(string id)
        {
            await client.GetAsync($"/api/{settings.Username}/sensors/{id}");
        }

        public async void UpdateSensor(string id)
        {
            await client.PutAsync($"/api/{settings.Username}/sensors/{id}", new StringContent(""));
        }

        public async void DeleteSensor(string id)
        {
            await client.DeleteAsync($"/api/{settings.Username}/sensors/{id}");
        }

        public async void ChangeSensorConfig(string id)
        {
            await client.PutAsync($"/api/{settings.Username}/sensors/{id}/config", new StringContent(""));
        }

        public async void ChangeSensorState(string id)
        {
            await client.PutAsync($"/api/{settings.Username}/sensors/{id}/state", new StringContent(""));
        }
    }
}
