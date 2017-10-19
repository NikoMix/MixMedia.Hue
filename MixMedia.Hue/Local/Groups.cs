using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.Hue.Local.Models;

namespace MixMedia.Hue.Local
{
    public class Groups
    {
        private HttpClient client;
        private ServiceSettings settings;

        public Groups(HttpClient client, ServiceSettings settings)
        {
            this.client = client;
            this.settings = settings;
        }

        public async Task<GroupCollection> GetAllGroups()
        {
            return await client.GetAsync<GroupCollection>($"/api/{settings.Username}/groups");
        }

        public async Task CreateGroup(Group group)
        {
            return await client.PostAsync($"/api/{settings.Username}/groups");
        }

        public async Task GetGroupAttributes(string id)
        {
            return await client.GetAsync($"/api/{settings.Username}/groups/{id}");
        }

        public async Task SetGroupAttributes(string id, object content)
        {
            return await client.PutAsync($"/api/{settings.Username}/groups/{id}", content);
        }

        public async Task SetGroupState(string id, object content)
        {
            return await client.PutAsync($"/api/{settings.Username}/groups/{id}/action", content);
        }

        public async Task DeleteGroup(string id)
        {
            return await client.DeleteAsync($"/api/{settings.Username}/groups/{id}");
        }
    }
}
