using System;
namespace ObserverPattern
{
    public class TemperatureValue : IWeatherValue
    {
        string tempValue;

        public TemperatureValue(int value)
        {
            this.tempValue = $"{value} Celsius";
        }

        public string GetValue()
        {
            return this.tempValue;
        }
    }
}
