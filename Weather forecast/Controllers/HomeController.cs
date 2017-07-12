using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Weather_forecast.Models;
using Weather_forecast.Services;

namespace Weather_forecast.Controllers
{
    public class HomeController : Controller
    {
        private IWeatherForecastService _weatherForecast;

        public HomeController(IWeatherForecastService weatherForecast)
        {
            _weatherForecast = weatherForecast;

        }

        // GET: Home/Index
        public ActionResult Index(string city, string dayCount)
        {
            city = city ?? "Kiev";
            dayCount = dayCount ?? "1";
            return View(_weatherForecast.GetWeatherInformation(city, dayCount));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Weather forecast";           

            return View();
        }

    }
}