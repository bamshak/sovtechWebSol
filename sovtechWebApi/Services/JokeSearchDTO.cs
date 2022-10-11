using Newtonsoft.Json;

namespace sovtechWebApi.Services
{
    public class JokeSearchDTO
    {
        [JsonProperty("total")]
        public string? Total { get; set; }
        [JsonProperty("result")]
        public JokesDTO[]? Results { get; set; }
    }
}
