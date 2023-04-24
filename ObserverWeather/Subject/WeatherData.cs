using System;
using System.Collections.Generic;
using ObserverWeather.Observer;

namespace ObserverWeather.Subject
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;

        private float temperature { get; set; }
        private int humidity { get; set; }
        private int pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetMeasurements(float temperature, int humidity, int pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public void MeasurementsChanged()
        {
            Console.WriteLine("Measurements changed, update subscribed displays:");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }

            Console.WriteLine();
        }
    }
}