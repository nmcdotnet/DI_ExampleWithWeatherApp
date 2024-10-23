using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_ExampleWithWeatherApp
{
    public class WeatherService : IWeatherService
    {
        public string GetWeather(string city)
        {
            return $"The weather in {city} is Sunny with 25°C.";
        }
    }
}
