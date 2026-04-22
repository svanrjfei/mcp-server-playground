using System.ComponentModel;
using ModelContextProtocol.Server;

namespace MyMcpServer.Tools;

/// <summary>
/// MCP tools for returning simple sample weather responses.
/// </summary>
internal class WeatherTools
{
    [McpServerTool]
    [Description("Describes random weather in the provided city.")]
    public string GetCityWeather(
        [Description("Name of the city to return weather for")]
        string city)
    {
        var weather = Environment.GetEnvironmentVariable("WEATHER_CHOICES");
        if (string.IsNullOrWhiteSpace(weather))
        {
            weather = "balmy,rainy,stormy";
        }

        var weatherChoices = weather
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        if (weatherChoices.Length == 0)
        {
            weatherChoices = ["balmy", "rainy", "stormy"];
        }

        var selectedWeatherIndex = Random.Shared.Next(0, weatherChoices.Length);
        return $"The weather in {city} is {weatherChoices[selectedWeatherIndex]}.";
    }
}
