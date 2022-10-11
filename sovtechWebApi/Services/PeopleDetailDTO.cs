﻿using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace sovtechWebApi.Services
{
    public class PeopleDetailDTO
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
        [JsonProperty("homeworld")]
        public string? HomeWorld { get; set; }
        [JsonProperty("films")]
        public List<string> Films { get; set; } = new List<string>();
        [JsonProperty("species")]
        public List<string> Species { get; set; } = new List<string>();
        [JsonProperty("vehicles")]
        public List<string> Vehicles { get; set; } = new List<string>();
        [JsonProperty("starships")]
        public List<string> StarShips { get; set; } = new List<string>();
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        [JsonProperty("edited")]
        public DateTime Edited { get; set; }
        [JsonProperty("url")]
        public string? URL { get; set; }
    }
}

