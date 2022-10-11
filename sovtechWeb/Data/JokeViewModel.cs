using Newtonsoft.Json;

namespace sovtechWeb.Data
{
    public class JokeViewModel
    {
        [JsonProperty("categories")]
        public List<string>? Categories { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("icon_url")]
        public string? IconUrl { get; set; }
        [JsonProperty("url")]
        public string? URL { get; set; }
        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
