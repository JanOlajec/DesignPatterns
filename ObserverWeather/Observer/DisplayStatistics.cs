using System;

namespace ObserverWeather.Observer
{
    public class DisplayStatistics : IObserver
    {
        public void Update(float t, int h, int p)
        {
            Console.WriteLine($"- Statistics temperature:{t}, humidity:{h}, pressure:{p}.");
        }
    }
}