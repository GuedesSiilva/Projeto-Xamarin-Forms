using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Services
{
    public class ApiServices<T> where T : class
    {
        private static HttpClient client;

        public static HttpClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new HttpClient();
                    client.BaseAddress = new Uri("http://10.0.2.2:5039/api/");
                }
                return client; }
        }

        public async static  Task<List<T>> getList(string url)
        {
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(content);
        }
    }
}
