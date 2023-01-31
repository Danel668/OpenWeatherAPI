using Newtonsoft.Json;

namespace OpenWeatherAPI.Models
{
    internal class OpenWeather
    {
        [JsonProperty("base")]
        public string Base { get; set; }
        public double visibility { get; set; }
        public double dt { get; set; }
        public double timezone { get; set; }
        public double id { get; set; }
        public string name { get; set; }
        public double cod { get; set; }
        public coord coord { get; set; }
        public weather[] weather { get; set; }
        public main main { get; set; }
        public snow snow { get; set; }
        public clouds clouds { get; set; }
        public sys sys { get; set; }
        public wind wind { get; set; }

    }
}
