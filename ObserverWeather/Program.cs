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

            var current = new DisplayCurrent();
            var stats = new DisplayStatistics();
            var forecast = new DisplayForecast();

            weather.AddObserver(current);
            weather.AddObserver(stats);
            weather.AddObserver(forecast);

            weather.SetMeasurements(12.8f, 60, 1020);
            weather.MeasurementsChanged();
            
            weather.SetMeasurements(20, 75, 1030);
            weather.MeasurementsChanged();

            weather.RemoveObserver(stats);
            weather.RemoveObserver(forecast);

            weather.SetMeasurements(33.5f, 80, 1035);
            weather.MeasurementsChanged();

            Console.ReadKey();
        }
    }
}
