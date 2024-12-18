using System;

namespace AbstractionOOP;

public class Car
{
    public string Make { get; private set; }
    public string Model { get; private set; }
    public int Year { get; private set; }

    // Constructor to initialize the properties
    public Car (string make, string model, int year )
    {
        Make = make;
        Model = model;
        Year = year;
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"{Make} {Model} {Year}");
    }
}
