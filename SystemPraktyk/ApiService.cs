using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace SystemPraktyk
{
    public class ApiService
    {
        public async Task<string> GetJsonAsync(string url)
        {
            using (var client = new HttpClient())
            {
                Debug.WriteLine("API DZIALA");
                return await client.GetStringAsync(url);
            }
        }
    }
}
