using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class TheWeather
    {
        public string CheckTheWeather()
        {
            Temperature temperature = new Temperature();
            AtmospherePressure atmospherePressure = new AtmospherePressure();
            AirHumidity airHumidity = new AirHumidity();
            WindSpeed windSpeed = new WindSpeed();

            int t = temperature.CheckTheTemperature();
            int atm = atmospherePressure.CheckTheAtmospherePressure();
            int air = airHumidity.CheckTheAirHumidity();
            int wind = windSpeed.CheckTheWindSpeed();

            return ($"The weather is good! Temperature {t} c, atmosphere pressure" +
                $" {atm}, air humidity {air}, windSpeed {wind} m/s");
        }
    }
    class Temperature
    {
        public int CheckTheTemperature()
        {
            Random random = new Random();
            return random.Next(0, 40);
        }
    }
    class AtmospherePressure
    {
        public int CheckTheAtmospherePressure()
        {
            Random random = new Random();
            return random.Next(600, 800);
        }
    }
    class AirHumidity
    {
        public int CheckTheAirHumidity()
        {
            Random random = new Random();
            return random.Next(20, 70);
        }
    }
    class WindSpeed
    {
        public int CheckTheWindSpeed()
        {
            Random random = new Random();
            return random.Next(0, 10);
        }
    }
}
