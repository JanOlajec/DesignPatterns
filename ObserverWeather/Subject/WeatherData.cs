using System;
using System.Collections.Generic;
using ObserverWeather.Observer;

namespace ObserverWeather.Subject
{
    /// <summary>
    /// Represent Subject in observer pattern
    /// </summary>
    public class WeatherData : ISubject
    {
        /// <summary>
        /// Store Observers which should be notified by Subject
        /// </summary>
        private readonly List<IObserver> observers;

        private float Temperature { get; set; }
        private int Humidity { get; set; }
        private int Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        /// <summary>
        /// Method for registering Observer to the Subject. Registered Observer will be notified by Subject.
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Cancel Observer subscription. Observer will be not notified by Subject anymore.
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Set or update weather data
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void SetMeasurements(float temperature, int humidity, int pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

        /// <summary>
        /// Trigger method for notifying Observers. Simulate reason (weather data change) for Observer notification.
        /// </summary>
        public void MeasurementsChanged()
        {
            Console.WriteLine("Measurements changed, update subscribed displays:");
            NotifyObservers();
        }

        /// <summary>
        /// Called common Observer interface for notifying them.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }

            Console.WriteLine();
        }
    }
}