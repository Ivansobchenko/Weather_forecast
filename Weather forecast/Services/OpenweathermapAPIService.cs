using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Weather_forecast.Models;

namespace Weather_forecast.Services
{
    public class OpenweathermapAPIService
    {

        public static WeatherForecast GetWeatherInformation(string cityName, string dayCount)
        {
            try
            {
                string requestUrl =
                    "http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt={1}&APPID={2}&type=accurate";
                string APIkey = "c93050a8791457a5e43ef1ef4e5cc19e";
                var request = string.Format(requestUrl, cityName, dayCount, APIkey);
                WebClient webClient = new WebClient();
                string response = webClient.DownloadString(request);
                return JsonConvert.DeserializeObject<WeatherForecast>(response);
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}