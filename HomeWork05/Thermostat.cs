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
class Program
{
    static void Main(string[] args)
    {
      
        Thermostat thermostat = new Thermostat();

      
        thermostat.TemperatureChanged += Thermostat_TemperatureChanged;

       
        thermostat.SetTemperature(30.5);
        thermostat.SetTemperature(22.0);
    }
    private static void Thermostat_TemperatureChanged(double newTemperature)
    {
        Console.WriteLine($"Temperature changed: {newTemperature}°C");
    }
}