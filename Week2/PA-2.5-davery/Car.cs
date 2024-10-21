/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Interface
*
* Interface class IAnimal - defines all methods that classes that
* implement this interface must implement.
*/

using System;

public class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public void Start()
    {
        Console.WriteLine($"The {Make} {Model} has started.");
    }

    public void Stop()
    {
        Console.WriteLine($"The {Make} {Model} has stopped.");
    }

    public void Drive(string destination)
    {
        Console.WriteLine($"The {Make} {Model} is driving to {destination}.");
    }

    public override string ToString()
    {
        return $"Car: {Make} {Model}";
    }
}