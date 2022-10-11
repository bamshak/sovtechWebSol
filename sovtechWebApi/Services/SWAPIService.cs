using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using sovtechWebApi.GraphQL;

namespace sovtechWebApi.Services
{
    public class SWAPIService : ISWAPIService
    {
        public async Task<PeopleHeaderDTO> GetSWApiPeopleAsync()
        {
            PeopleHeaderDTO Result = new PeopleHeaderDTO();
            using (var client = new RestClient("https://swapi.dev/api/people"))
            {
                var request = new RestRequest(string.Empty, Method.Get) { RequestFormat = DataFormat.Json };

                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    Result = JsonConvert.DeserializeObject<PeopleHeaderDTO>(response.Content);
                }
                return Result;
            }
        }

        public async Task<PeopleHeaderDTO> SearchSWApiPeopleAsync(string? search)
        {
            PeopleHeaderDTO ResultList = null;
            using (var client = new RestClient("https://swapi.dev/api/people/?"))
            {
                var request = new RestRequest(string.Empty, Method.Get) { RequestFormat = DataFormat.Json };
                request.AddParameter("search", search);
                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    ResultList = JsonConvert.DeserializeObject<PeopleHeaderDTO>(response.Content);
                }
                return ResultList;
            }
        }
    }
}
