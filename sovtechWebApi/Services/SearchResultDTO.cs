using Newtonsoft.Json;

namespace sovtechWebApi.Services
{
    public class SearchResultDTO
    {
        //[JsonProperty("jokesQuerySearch")]
        //public string? SearchType { get; set; }
        [JsonProperty("sWAPIPeopleSearch")]
        public dynamic SWAPI { get; set; } 
        [JsonProperty("jokesQuerySearch")]
        public dynamic ChuckNorrisData { get; set; }
    }



}
