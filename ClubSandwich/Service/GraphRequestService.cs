using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Realms;
using System.Net.Http;
using ClubSandwich.Service;

namespace ClubSandwich.Services
{
    public class GraphRequestProvider
    {
        private readonly HttpClient _client;
        private Realm _realm;

        public GraphRequestProvider()
        {
            _realm = RealmConnection.GetInstance();

            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer ");
            _client.DefaultRequestHeaders.Add("Pragma", "no-cache");
            _client.DefaultRequestHeaders.Add("Cache-Control", "no-cache, no-store, must-revalidate");
        }

        public async Task<GraphResult<T>> Query<T>(string query)
        {
            var graphQuery = new { query };
            var content = new StringContent(JsonConvert.SerializeObject(graphQuery), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("https://api.sandwichclub.tk/graphiql", content);
            var json = await response.Content.ReadAsStringAsync();

            var graphResult = JsonConvert.DeserializeObject<GraphResult<T>>(json);
            graphResult.StatusCode = response.StatusCode;

            return graphResult;
        }
    }
}