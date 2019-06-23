using System;
namespace ObserverPattern
{
    public class WindDisplay : IObserver
    {

        public void Update<T>(T wind_value)
        {
            
            Console.WriteLine("Wind Display: " +
                (wind_value is WindValue ? (wind_value as WindValue).GetValue() : "Incorrect value update"));
        }
    }
}
