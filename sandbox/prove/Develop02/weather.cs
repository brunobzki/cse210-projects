using System;
using System.Collections.Generic;

public class Weather
{
    public string Location { get; set; }
    public DateTime Date { get; set; }
    public double TemperatureCelsius { get; set; }

    public Weather(string location, DateTime date, double temperatureCelsius)
    {
        Location = location;
        Date = date;
        TemperatureCelsius = temperatureCelsius;
    }

    public double GetTemperatureFahrenheit()
    {
        return (TemperatureCelsius * 9 / 5) + 32;
    }
}
