using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdminForm
{
    public class PerformService
    {
        HttpClient client = new HttpClient();
        public PerformService()
        {
            string url = $"{ConfigurationManager.AppSettings["ApiAddress"]}api/Perform/";
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> GetsListAsync<T>(string path, T t)
        {
            T obj = default(T);
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        obj = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                        return obj;
                    }
                    return obj;
                }
            }
            catch (Exception)
            {

                return obj;
            }
        }
    }
}
