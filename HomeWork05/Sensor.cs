using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork05
{
}

public delegate void MeasurementUpdatedEventHandler(double averageMeasurement);
public class Sensor
{
    public List<double> measurements = new List<double>();
    public event MeasurementUpdatedEventHandler MeasurementUpdated;
    public void AddMeasurement(double newMeasurement, Func<double, bool> filter)
    {
        if (filter(newMeasurement))
        {
            measurements.Add(newMeasurement);
            double average = measurements.Average();
            OnMeasurementUpdated(average);
        }
    }
    protected virtual void OnMeasurementUpdated(double averageMeasurement)
    {
        MeasurementUpdated?.Invoke(averageMeasurement);
    }
}
class Program0
{
    static void Main(string[] args)
    {
       
        Sensor sensor = new Sensor();

        sensor.MeasurementUpdated += Sensor_MeasurementUpdated;

       
        sensor.AddMeasurement(10.0, m => m > 0); 
        sensor.AddMeasurement(20.0, m => m > 0); 
        sensor.AddMeasurement(-5.0, m => m > 0); 
        sensor.AddMeasurement(30.0, m => m > 0); 
        sensor.AddMeasurement(40.0, m => m > 0); 
    }

    
    private static void Sensor_MeasurementUpdated(double averageMeasurement)
    {
        Console.WriteLine($"Average measurement: {averageMeasurement}");
    }
}