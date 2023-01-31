namespace OpenWeatherAPI
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            await HttpControl.GetResponse();
        }
    }
}