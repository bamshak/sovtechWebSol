using Newtonsoft.Json;

namespace sovtechWeb.Data
{
    public class PeopleMetaViewModel
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("next")]
        public string? Next { get; set; }
        [JsonProperty("previous")]
        public string? Previous { get; set; }
        [JsonProperty("results")]
        public PeopleViewModel[]? Results { get; set; }
    }
}
