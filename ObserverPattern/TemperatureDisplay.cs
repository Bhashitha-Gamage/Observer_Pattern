using System;
namespace ObserverPattern
{
    public class TemperatureDisplay : IObserver
    {

        public void Update<IWeatherValue>(IWeatherValue temp_value)
        {
            Console.WriteLine("Temperature Display: " +
                (temp_value is TemperatureValue ? (temp_value as TemperatureValue).GetValue() : "Incorrect value update"));

        }
    }
}
