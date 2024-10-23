using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_ExampleWithWeatherApp
{
    public interface IWeatherService
    {
        string GetWeather(string city);
    }
}
