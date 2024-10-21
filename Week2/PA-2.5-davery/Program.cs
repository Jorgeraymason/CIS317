/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Interface
*
* Interface class IAnimal - defines all methods that classes that
* implement this interface must implement.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Devin Avery - Week 2 Interface Performance Assessment");

        Car car1 = new Car("Toyota", "Camry");
        Car car2 = new Car("Honda", "Accord");
        CargoTruck truck1 = new CargoTruck("Volvo", "5000kg");
        CargoTruck truck2 = new CargoTruck("Mercedes", "7000kg");

        car1.Start();
        car2.Start();
        truck1.Start();
        truck2.Start();

        car1.Drive("Beach");
        car2.Drive("Mountains");
        truck1.Drive("Warehouse");
        truck2.Drive("Port");

        truck1.Stop();

        List<IVehicle> vehicles = new List<IVehicle> { car1, car2, truck1, truck2 };

        PrintVehicleList(vehicles);
        PrintVehicleDetails(car1, car2, truck1, truck2);
    }

    private static void PrintVehicleInfo(IVehicle vehicle)
    {
        Console.WriteLine(vehicle.ToString());
    }

    private static void PrintVehicleList(List<IVehicle> vehicles)
    {
        Console.WriteLine("List of Vehicles:");
        foreach (var vehicle in vehicles)
        {
            PrintVehicleInfo(vehicle);
        }
        Console.WriteLine();
    }

    private static void PrintVehicleDetails(params IVehicle[] vehicles)
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Printing details for {vehicle.GetType().Name}:");
            PrintVehicleInfo(vehicle);
            Console.WriteLine();
        }
    }
}