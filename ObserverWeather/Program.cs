using System;

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

            weather.MeasurementsChanged();

            Console.ReadKey();
        }
    }
}
