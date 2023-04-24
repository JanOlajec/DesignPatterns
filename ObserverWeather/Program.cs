using System;
using ObserverWeather.Observer;
using ObserverWeather.Subject;

namespace ObserverWeather
{
    // ReSharper disable once ClassNeverInstantiated.Global
    /// <summary>
    /// Console program main
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            var weather = new WeatherData();

            weather.Temperature = 12.8f;
            weather.Humidity = 60;
            weather.Pressure = 1025;

            var current = new DisplayCurrent();
            var stats = new DisplayStatistics();
            var forecast = new DisplayForecast();

            weather.AddObserver(current);
            weather.AddObserver(stats);
            weather.AddObserver(forecast);

            weather.NotifyObservers();
            
            weather.Temperature = 20f;
            weather.Humidity = 75;

            weather.NotifyObservers();

            Console.ReadKey();
        }
    }
}
