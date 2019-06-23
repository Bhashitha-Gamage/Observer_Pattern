using System;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Update<T>(T value);
    }
}