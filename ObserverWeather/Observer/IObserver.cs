namespace ObserverWeather.Observer
{
    public interface IObserver
    {
        void Update(float t, int h, int p);
    }
}