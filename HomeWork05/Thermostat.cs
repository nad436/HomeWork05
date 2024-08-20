using System;
public delegate void TemperatureChangedEventHandler(double newTemperature);
public class Thermostat
{
    public event TemperatureChangedEventHandler TemperatureChanged;
    public double currentTemperature;

    public void SetTemperature(double newTemperature)
    {
        if (currentTemperature != newTemperature)
        {
            currentTemperature = newTemperature;
            OnTemperatureChanged(newTemperature);
        }
    }
    protected virtual void OnTemperatureChanged(double newTemperature)
    {

        TemperatureChanged?.Invoke(newTemperature);
    }

}
