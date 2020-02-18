using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MandarinNews.Model
{
    class VolgogradNewsParser
    {
        public static async Task<List<VolgogradParsed>> GetNewsText(string City)
        {
            string requestString = "https://api.newsriver.io/v2/search?query=text%3A" + City + "&sortBy=discoverDate&sortOrder=DESC&limit=34";
            string requestAuth = "sBBqsGXiYgF0Db5OV5tAwzoUfGnLTDYA2h-nZeYFA0vJ2UiSIQj6cx665kxZn0xAn2pHZrSf1gT2PUujH1YaQA";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(requestAuth);

            HttpResponseMessage response = (await client.GetAsync(requestString)).EnsureSuccessStatusCode();
            string responceString = await response.Content.ReadAsStringAsync();

            JArray jArray = JArray.Parse(responceString);

            List<VolgogradParsed> news = jArray.ToObject<List<VolgogradParsed>>();

            jArray.Clear();

            return news;
        }
    }
}
