using OpenWeatherAPI.Models;
using static System.Console;

namespace OpenWeatherAPI
{
    public static class ProgramControl
    {
        public static string GetCity()
        {
            WriteLine("Your city: (Example: Moscow, London)");
            string? City = ReadLine();

            if (City != null)
                return City;
            else
            {
                WriteLine("Thit city doesn`t exist");
                return GetCity();
            }
        }

        public static string? GetKey()
        {
            WriteLine("Write you key or just click enter");
            string? defKEy = ReadLine();
            if (defKEy == "")
                return "66b2c34c026ea7c6db8ee9cd9c5d23d2";
            return defKEy;
        }


        internal static void OutPut(OpenWeather? info)
        {
            WriteLine("Info:");
            WriteLine($"It`s {info?.weather?.FirstOrDefault()?.main}");
            WriteLine($"Description: {info?.weather?.FirstOrDefault()?.description}");
            WriteLine($"Temperature: {info?.main?.temp}");
            WriteLine($"Feels like {info?.main?.feels_like}");
            WriteLine($"Min temperature: {info?.main?.temp_min}");
            WriteLine($"Max temperature: {info?.main?.temp_max}");
            WriteLine($"Pressure: {info?.main?.pressure}");
            WriteLine($"Visibility: {info?.visibility}");
            WriteLine($"Wind speed: {info?.wind?.speed}");
        }
    }
}
