/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Interface
*
* Interface class IAnimal - defines all methods that classes that
* implement this interface must implement.
*/

using System;

public class CargoTruck : IVehicle
{
    public string Brand { get; set; }
    public string Capacity { get; set; }

    public CargoTruck(string brand, string capacity)
    {
        Brand = brand;
        Capacity = capacity;
    }

    public void Start()
    {
        Console.WriteLine($"The {Brand} cargo truck has started.");
    }

    public void Stop()
    {
        Console.WriteLine($"The {Brand} cargo truck has stopped.");
    }

    public void Drive(string destination)
    {
        Console.WriteLine($"The {Brand} cargo truck is delivering goods to {destination}.");
    }

    public override string ToString()
    {
        return $"Cargo Truck: {Brand} ({Capacity})";
    }
}