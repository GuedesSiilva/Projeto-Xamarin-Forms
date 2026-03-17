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
                    client.BaseAddress = new Uri("http://localhost:5039/api/");
                }
                return client; }
        }

        public async static  Task<List<T>> getList(string url)
        {
            var response = await client.GetAsync(url);
            var contest = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<T>>(contest);
            return json;
        }
    }
}
