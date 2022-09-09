using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;
        private double NEW_TEMPERATURE;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
            NEW_TEMPERATURE = (9.0 / 5.0) * _temperature + 32;
        }

        public string PrintClimate()
        {
            return $"I am in {_location} and it is {CheckLocation()}. {CheckTemperature()}. The temperature in Fahrenheit is {newTemp}.";
        }

        public string CheckLocation()
        {
            if (_location == "London")
            { return "🌦";}
            else if (_location == "California")
            {return "🌅";}
            else if (_location == "Cape Town")
            {return "🌤";}
            return "🔆";}

        public string CheckTemperature()
        {
            if (_temperature > 30)
            { return "It's too hot 🥵!";}
            else if (_temperature < 10)
            { return "It's too cold 🥶!";}
            return "Ahhh...it's just right 😊!";
        }

    }
}

