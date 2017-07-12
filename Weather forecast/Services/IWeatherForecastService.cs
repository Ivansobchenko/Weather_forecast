using Weather_forecast.Models;

namespace Weather_forecast.Services
{
    public interface IWeatherForecastService
    {
        WeatherForecast GetWeatherInformation(string cityName, string dayCount);
    }
}