using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Notify()
        {
            // To demonstrate: we trigger 100  weather updates.
            int x = 0;
            while (x < 100)
            {
                Random randomGenerator = new Random();
                int temperature = randomGenerator.Next(50);
                int windSpeed = randomGenerator.Next(100);

                foreach (var observer in observers)
                {
                    switch (observer)
                    {
                        case TemperatureDisplay tempDisplay:
                            tempDisplay.Update(new TemperatureValue(temperature));
                            break;

                        case WindDisplay windDisplay:
                            windDisplay.Update(new WindValue(windSpeed));
                            break;
                    }
                }
                Console.WriteLine(string.Empty);
                x++;
            }
        }

        public void Remove(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}
