using System;
namespace ObserverPattern
{
    public class WindValue : IWeatherValue
    {
        string windValue;
        public WindValue(int value)
        {
            this.windValue = $"{value} mph";
        }

        public string GetValue()
        {
            return this.windValue;
        }
    }
}
