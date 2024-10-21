using System;

/// Author: [Devin Avery]
/// Date: [10/19/2024]
/// Assignment: SDC320 Performance Assessment - Constructors and Access Specifiers
/// Description: Base class representing a car.
public class Car
{
    public string Model { get; set; }

    public Car()
    {
        Model = "Generic Car";
    }

    public Car(string model)
    {
        Model = model;
    }

    public override string ToString()
    {
        return $"Car Model: {Model}";
    }
}