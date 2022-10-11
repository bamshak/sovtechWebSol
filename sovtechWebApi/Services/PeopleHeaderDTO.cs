using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace sovtechWebApi.Services
{
    public class PeopleHeaderDTO
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("next")]
        public string? Next { get; set; }
        [JsonProperty("previous")]
        public string? Previous { get; set; }
        [JsonProperty("results")]
        public PeopleDetailDTO[]? Results { get; set; }
    }
}
