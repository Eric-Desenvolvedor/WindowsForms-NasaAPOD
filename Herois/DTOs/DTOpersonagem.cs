using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Linq;

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
    public class aparenciaPersonagem
    {
        public List<string> weight { get; set; } = new();
        public string gender { get; set; } = "";

    }

    public class poderesStatus
    {
        public string intelligence { get; set; } = "";
        public string strength { get; set; } = "";
        public string speed { get; set; } = "";
        public string durability { get; set; } = "";
        public string power { get; set; } = "";
        public string combat { get; set; } = "";
    }

    public class dadosPersonagem
    {
        public ImageDto image { get; set; } = new();
        public aparenciaPersonagem appearance { get; set; } = new();
        public BiographyDto biography { get; set; } = new();
        public string name { get; set; } = "";
        public poderesStatus powerstats { get; set; } = new();
    }
}