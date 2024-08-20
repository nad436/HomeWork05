using HomeWork05;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

class Program
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

        Thermostat thermostat = new Thermostat();


        thermostat.TemperatureChanged += Thermostat_TemperatureChanged;


        thermostat.SetTemperature(30.5);
        thermostat.SetTemperature(22.0);

        List<int> list = new List<int>() {12, 2233, 32};

        ExtentionMethod.Average(list);

        Lambda.LambdaExpression(list);
    }


    private static void Sensor_MeasurementUpdated(double averageMeasurement)
    {
        Console.WriteLine($"Average measurement: {averageMeasurement}");
    }
    private static void Thermostat_TemperatureChanged(double newTemperature)
    {
        Console.WriteLine($"Temperature changed: {newTemperature}°C");
    }
    
}


