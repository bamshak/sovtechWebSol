using Newtonsoft.Json;

namespace sovtechWeb.Data
{
    public class PeopleViewModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("mass")]
        public int Mass { get; set; } = 0;
        [JsonProperty("hair_color")]
        public string? HairColor { get; set; }
        [JsonProperty("skin_color")]
        public string? SkinColor { get; set; }
        [JsonProperty("eye_color")]
        public string? EyeColor { get; set; }
        [JsonProperty("birth_year")]
        public string? BirthYear { get; set; }
        [JsonProperty("gender")]
        public string? Gender { get; set; }
        //[JsonProperty("homeworld")]
        //public string? HomeWorld { get; set; }
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        [JsonProperty("url")]
        public string? URL { get; set; }
    }
}
