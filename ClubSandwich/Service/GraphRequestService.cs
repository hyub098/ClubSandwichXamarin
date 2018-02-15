using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Realms;
using System.Net.Http;
using ClubSandwich.Service;
using ClubSandwich.Model;
using System.Linq;

namespace ClubSandwich.Services
{
    public class GraphRequestProvider
    {
        private readonly HttpClient _client;
        private Realm _realm;

        public GraphRequestProvider()
        {
            _realm = RealmConnection.GetInstance();

            var token = _realm.All<LoginCredential>().FirstOrDefault().Token;

            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }

        public async Task<GraphResult<T>> Query<T>(string query)
        {
            var graphQuery = new { query };
            var content = new StringContent(JsonConvert.SerializeObject(graphQuery), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("https://api.sandwichclub.tk/graphql", content);
            var json = await response.Content.ReadAsStringAsync();

            var graphResult = JsonConvert.DeserializeObject<GraphResult<T>>(json);
            graphResult.StatusCode = response.StatusCode;

            return graphResult;
        }
    }
}