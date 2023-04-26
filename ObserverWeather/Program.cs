using System;
using ObserverWeather.Observer;
using ObserverWeather.Subject;

namespace ObserverWeather
{
    /// <summary>
    /// Console program main with example of usage observer pattern in weather station.
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            // Create Subject WeatherData which will provide information to Observers.
            var weather = new WeatherData();

            // Create Observers which will be notified by Subject
            // Observers can be added/registered to the Subject implicitly during instance creation or during runtime.
            // Observer DisplayCurrent is registered in constructor.
            _ = new DisplayCurrent(weather);
            
            // These Observers are only created but not registered yet. 
            var stats = new DisplayStatistics();
            var forecast = new DisplayForecast();

            // Adding Observers to the Subject
            weather.AddObserver(stats);
            weather.AddObserver(forecast);

            // Set some measurements values and notify Observers
            // Notifying is realized over method Update() defined in interface IObserver
            weather.SetMeasurements(12.8f, 60, 1020);
            weather.MeasurementsChanged();

            weather.RemoveObserver(stats);

            // Set some measurements values and notify only remaining (registered) Observers 
            weather.SetMeasurements(20, 75, 1030);
            weather.MeasurementsChanged();
            
            weather.RemoveObserver(forecast);

            weather.SetMeasurements(33.5f, 80, 1035);
            weather.MeasurementsChanged();

            Console.ReadKey();
        }
    }
}
