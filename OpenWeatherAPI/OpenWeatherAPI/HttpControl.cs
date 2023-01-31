using Newtonsoft.Json;
using OpenWeatherAPI.Models;

namespace OpenWeatherAPI
{
    public static class HttpControl
    {
        internal static async Task<OpenWeather?> GetRequest(string city, string? key)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client
                    .GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&APPID={key}");

                var json = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Неверно указан город или ключ");

                OpenWeather? openWeather = JsonConvert.DeserializeObject<OpenWeather>(json);

                if (openWeather == null )
                    throw new Exception("Ошибка десериализации");

                return openWeather;
            }
        }

        internal static async Task GetResponse()
        {
            string city = ProgramControl.GetCity();
            string? key = ProgramControl.GetKey();

            OpenWeather? info = await GetRequest(city, key);
            ProgramControl.OutPut(info);
        }
    }
}
