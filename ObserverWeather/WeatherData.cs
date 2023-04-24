using System;

namespace ObserverWeather
{
    public class WeatherData
    {
        public float Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }

        private void DisplayCurrent(float t, int h, int p)
        {
            Console.WriteLine($"Current temperature:{t}, humidity:{h}, pressure:{p}.");
        }
        private void DisplayStatistics(float t, int h, int p)
        {
            Console.WriteLine($"Statistics temperature:{t}, humidity:{h}, pressure:{p}.");
        }
        private void DisplayForecast(float t, int h, int p)
        {
            Console.WriteLine($"Forecast temperature:{t}, humidity:{h}, pressure:{p}.");
        }

        public void MeasurementsChanged()
        {
            Console.WriteLine("Measurements changed, update displays");

            float tmpr = Temperature;
            int hmd = Humidity;
            int prss = Pressure;

            DisplayCurrent(tmpr, hmd, prss);
            DisplayStatistics(tmpr, hmd, prss);
            DisplayForecast(tmpr, hmd, prss);

        }
    }
}