using ObserverWeather.Observer;

namespace ObserverWeather.Subject
{
    internal interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
