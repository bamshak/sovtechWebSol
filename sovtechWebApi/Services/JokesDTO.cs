using Newtonsoft.Json;

namespace sovtechWebApi.Services
{
    public class JokesDTO
    {
        [JsonProperty("id")]
        public string? Id { get; set; }
        [JsonProperty("categories")]
        public List<string>? Categories { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("icon_url")]
        public string? IconUrl { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("url")]
        public string? URL { get; set; }
        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
