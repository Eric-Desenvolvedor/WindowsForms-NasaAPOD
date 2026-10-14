using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Herois.DTOs
{
    public class SuperHeroApiResponse
    {
        public string response { get; set; } = "";
        public List<DTOpersonagem> results { get; set; } = new();
    }

    public class DTOpersonagem
    {
        public string id { get; set; } = "";
        public string name { get; set; } = "";
        public BiographyDto biography { get; set; } = new();
        public ImageDto image { get; set; } = new();
    }

    public class ImageDto
    {
        public string url { get; set; } = "";
    }

    public class BiographyDto
    {
        public string publisher { get; set; } = "";

        [JsonPropertyName("full-name")]
        public string FullName { get; set; } = "";
    }
}