/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Polymorphism – Building Information 
*/

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("Devin Avery - Week 2 Polymorphism Performance Assessment");

        Building building = new Building("123 Main St", 5);
        Condominium condo = new Condominium("456 Oak St", 10, 20);
        House house = new House("789 Pine St", 2, 3);
        SplitLevel splitLevel1 = new SplitLevel("101 Elm St", 3, 4, true);
        SplitLevel splitLevel2 = new SplitLevel("202 Maple St", 2, 3, false);

        var buildingsList = new ArrayList { building, condo, house, splitLevel1, splitLevel2 };
        var housesList = new ArrayList { house, splitLevel1, splitLevel2 };

        PrintBuildingInfo(buildingsList);
        PrintBuildingInfo(housesList);
    }

    private static void PrintBuildingInfo(Building building)
    {
        Console.WriteLine("Building Information:");
        Console.WriteLine(building.ToString());
        Console.WriteLine();
    }

    private static void PrintBuildingInfo(ArrayList buildings)
    {
        Console.WriteLine("List of Buildings Information:");
        foreach (var building in buildings)
        {
            Console.WriteLine(building.ToString());
        }
    }
}