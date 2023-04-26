using ObserverWeather.Subject;
using System;

namespace ObserverWeather.Observer
{
    public class DisplayCurrent : IObserver
    {
        public DisplayCurrent(WeatherData weather)
        {
            // Example, where Observer is added to Subject in own constructor, we can say by 'default'.
            weather.AddObserver(this);
        }
        public void Update(float t, int h, int p)
        {
            Console.WriteLine($"- Current temperature:{t}, humidity:{h}, pressure:{p}.");
        }
    }
}