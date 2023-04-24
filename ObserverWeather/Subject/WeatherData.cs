using System;
using System.Collections.Generic;
using ObserverWeather.Observer;

namespace ObserverWeather.Subject
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;

        public float Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Measurements changed, update displays:");

            float tmpr = Temperature;
            int hmd = Humidity;
            int prss = Pressure;

            foreach (IObserver observer in observers)
            {
                observer.Update(tmpr, hmd, prss);
            }

            Console.WriteLine();
        }
    }
}