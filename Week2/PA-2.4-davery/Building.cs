/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Polymorphism – Building Information 
*/

using System;

public class Building
{
    public string Address { get; set; }
    public int Floors { get; set; }

    public Building(string address, int floors)
    {
        Address = address;
        Floors = floors;
    }

    public override string ToString()
    {
        return $"Address: {Address}, Floors: {Floors}";
    }
}