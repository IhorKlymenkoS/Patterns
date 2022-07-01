using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TheWeather weather = new TheWeather();
            Console.WriteLine(weather.CheckTheWeather());
        }
    }
}
