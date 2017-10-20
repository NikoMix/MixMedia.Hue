using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.Hue.Local.Manager
{
    public class SchedulesManager
    {
        private HttpClient client;
        private ServiceSettings settings;

        public SchedulesManager(HttpClient client, ServiceSettings settings)
        {
            this.client = client;
            this.settings = settings;
        }

        public async void GetAllSchedules()
        {
            await client.GetAsync($"/api/{settings.Username}/schedules");
        }

        public async void CreateSchedule()
        {
            await client.PostAsync($"/api/{settings.Username}/schedules", new StringContent(""));
        }

        public async void GetScheduleAttributes(string id)
        {
            await client.GetAsync($"/api/{settings.Username}/schedules/{id}");
        }

        public async void SetScheduleAttributes(string id)
        {
            await client.PutAsync($"/api/{settings.Username}/schedules/{id}", new StringContent(""));
        }

        public async void DeleteSchedule(string id)
        {
            await client.DeleteAsync($"/api/{settings.Username}/schedules/{id}");
        }
    }
}
