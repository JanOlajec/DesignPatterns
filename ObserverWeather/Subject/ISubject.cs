using ObserverWeather.Observer;

namespace ObserverWeather.Subject
{
    internal interface ISubject
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
