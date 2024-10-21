using System;

/// Author: [Devin Avery]
/// Date: [10/19/2024]
/// Assignment: SDC320 Performance Assessment - Constructors and Access Specifiers
/// Description: Class representing a gas-powered car.

public class GasCar : Car
{
    public GasCar() : base()
    {
        Model = "Gas Car";
    }

    public GasCar(string model) : base(model)
    {
    }
}