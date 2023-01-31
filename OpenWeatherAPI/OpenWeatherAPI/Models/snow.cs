using Newtonsoft.Json;

namespace OpenWeatherAPI.Models
{
    internal class snow
    {
        [JsonProperty("1h")]
        public double H { get; set; }
    }
}
