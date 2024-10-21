using System;
using System.Collections.Generic;

/// Author: [Devin Avery]
/// Date: [10/19/2024]
/// Assignment: SDC320 Performance Assessment - Constructors and Access Specifiers
/// Description: Class representing a parking lot that can hold different types of cars.
public class ParkingLot
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public List<Car> GetCars()
    {
        return cars;
    }
}