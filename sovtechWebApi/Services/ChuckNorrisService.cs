using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace sovtechWebApi.Services
{
    public class ChuckNorrisService : IChuckNorrisService
    {
        public async Task<JokesDTO> GetRandomJokesByCategoriesAsync(string categoryId)
        {
            JokesDTO ResultList = new JokesDTO();
            using (var client = new RestClient("https://api.chucknorris.io/jokes/random?"))
            {
                var request = new RestRequest(string.Empty, Method.Get) { RequestFormat = DataFormat.Json };
                request.AddParameter("category", categoryId);
                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    ResultList = JsonConvert.DeserializeObject<JokesDTO>(response.Content);
                }
                return ResultList;
            }
        }

        public async Task<List<string>> AllJokesCategoriesAsync()
        {
            List<string> ResultList = new List<string>();
            using (var client = new RestClient("https://api.chucknorris.io/jokes/categories"))
            {
                var request = new RestRequest(string.Empty, Method.Get) { RequestFormat = DataFormat.Json };

                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    ResultList = JsonConvert.DeserializeObject<List<string>>(response.Content);
                }
                return ResultList;
            }
        }

        public async Task<JokeSearchDTO> SearchRandomJokes(string? query)
        {
            JokeSearchDTO ResultList = new JokeSearchDTO();
            using (var client = new RestClient("https://api.chucknorris.io/jokes/search?"))
            {
                var request = new RestRequest(string.Empty, Method.Get) { RequestFormat = DataFormat.Json };
                request.AddParameter("query", query);
                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    ResultList = JsonConvert.DeserializeObject<JokeSearchDTO>(response.Content);
                }
                return ResultList;
            }
        }
    }
}
