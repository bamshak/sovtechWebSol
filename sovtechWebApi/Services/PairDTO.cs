using Newtonsoft.Json;

namespace sovtechWebApi.Services
{
    public class PairDTO
    {
        [JsonProperty("sWAPIPeopleSearch")]
        public dynamic? SWAPI { get; set; }
        [JsonProperty("jokesQuerySearch")]
        public dynamic? ChuckNorrisData { get; set; }
    }
}
