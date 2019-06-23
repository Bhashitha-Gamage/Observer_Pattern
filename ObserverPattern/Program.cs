using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create weather station - Observable
            WeatherStation weatherStation = new WeatherStation();

            // Create Displays - Observers
            TemperatureDisplay temperatureDisplay = new TemperatureDisplay();
            WindDisplay windDisplay = new WindDisplay();

            // Add Observers to Observable
            weatherStation.Add(temperatureDisplay);
            weatherStation.Add(windDisplay);

            // To demonstrate, manually triiger the Notify() of the observable
            weatherStation.Notify();
        }
    }
}
