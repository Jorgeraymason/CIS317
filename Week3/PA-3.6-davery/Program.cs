/*******************************************************************
* Name: Devin Avery
* Date: 10/19/2024
* Assignment: SDC320 Week 3 PA – Constructors and Access Specifiers
*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Devin Avery - Week 3 Constructors and Access Specifiers Performance Assessment");

        ParkingLot parkingLot = new ParkingLot();

        ElectricCar electricCar = new ElectricCar();
        GasCar gasCar1 = new GasCar("Gas Car 1");
        GasCar gasCar2 = new GasCar();

        parkingLot.AddCar(electricCar);
        parkingLot.AddCar(gasCar1);
        parkingLot.AddCar(gasCar2);

        Console.WriteLine("Cars in the Parking Lot");
        foreach (Car car in parkingLot.GetCars())
        {
            Console.WriteLine(car.ToString());
        }
    }
}