/*******************************************************************
* Name: Devin Avery
* Date: 10/29/2024
* Assignment: SDC320 Week 5 - FINAL PROJECT
*/
//Main program class that outputs the final product
using System;

namespace devave9719_FINAL_PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry point of the program
            // You can instantiate objects and perform operations here
            // For example:
            
            // Create objects
            Door frontDoor = new Door(80, "Brown");
            Kitchen mainKitchen = new Kitchen("Modern", "BrandX");
            House myHouse = new House(3, frontDoor, mainKitchen);

            // Display information
            Console.WriteLine(myHouse.ToString());
        }
    }
}