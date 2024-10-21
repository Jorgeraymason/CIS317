/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Polymorphism – Building Information 
*/

using System;
public class Condominium : Building
{
    public int Units { get; set; }

    public Condominium(string address, int floors, int units) : base(address, floors)
    {
        Units = units;
    }

    public override string ToString()
    {
        return $"Address: {Address}, Floors: {Floors}, Units: {Units}";
    }
}