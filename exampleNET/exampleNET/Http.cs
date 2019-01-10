using System.Net.Http;
using System.Threading.Tasks;

namespace exampleNET
{
    public class Http
    {
        private readonly string _baseUrl = "https://jsonplaceholder.typicode.com/";

        public async Task<string> GetData(string path)
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(_baseUrl + path);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
