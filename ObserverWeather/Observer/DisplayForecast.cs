using System;

namespace ObserverWeather.Observer
{
    public class DisplayForecast : IObserver
    {
        public void Update(float t, int h, int p)
        {
            Console.WriteLine($"Forecast temperature:{t}, humidity:{h}, pressure:{p}.");
        }
    }
}