/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Polymorphism – Building Information 
*/

using System;

public class SplitLevel : House
{
    public bool HasBasement { get; set; }

    public SplitLevel(string address, int floors, int bedrooms, bool hasBasement) : base(address, floors, bedrooms)
    {
        HasBasement = hasBasement;
    }

    public override string ToString()
    {
        return $"Address: {Address}, Floors: {Floors}, Bedrooms: {Bedrooms}, Has Basement: {HasBasement}";
    }
}