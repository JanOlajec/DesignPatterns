namespace ObserverWeather.Observer
{
    public interface IObserver
    {
        void Update(float temperature, int humidity, int pressure);
    }
}