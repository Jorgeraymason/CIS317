/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Polymorphism – Building Information 
*/

using System;

public class House : Building
{
    public int Bedrooms { get; set; }

    public House(string address, int floors, int bedrooms) : base(address, floors)
    {
        Bedrooms = bedrooms;
    }

    public override string ToString()
    {
        return $"Address: {Address}, Floors: {Floors}, Bedrooms: {Bedrooms}";
    }
}