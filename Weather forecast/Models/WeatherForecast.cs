using System.Collections.Generic;

namespace Weather_forecast.Models
{

    public class WeatherForecast
    {
        public City city { get; set; }
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<WeatherforecastForDay> list { get; set; }
    }

    public class Coordinates
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coordinates coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
    }

    public class TemperatureInformation
    {
        public double day { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public double night { get; set; }
        public double eve { get; set; }
        public double morn { get; set; }
    }

    public class WeatherDescription
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
    public class WeatherforecastForDay
    {
        public int dt { get; set; }
        public TemperatureInformation temp { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public List<WeatherDescription> weather { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public int clouds { get; set; }
        public double? rain { get; set; }
    }


}