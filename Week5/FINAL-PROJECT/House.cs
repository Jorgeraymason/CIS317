/// Author: Devin Avery
/// Date: Date of development
/// Assignment: SDC320 Final Practical
/// Description: Represents a house, derived from Building.
/// Concepts: Inheritance, Composition, Polymorphism, Use of Constructo
using System;

namespace devave9719_FINAL_PROJECT
{
    /// <summary>
    /// Author: Your Name
    /// Date: Date of development
    /// Assignment: SDC320 Final Practical
    /// Description: Represents a house, derived from Building.
    /// Concepts: Inheritance, Composition, Polymorphism, Use of Constructors
    /// </summary>
    public class House : Building
    {
        private int NumRooms;
        private Door FrontDoor;
        private Kitchen MainKitchen;

        public House(int numRooms, Door frontDoor, Kitchen mainKitchen) : base("House")
        {
            NumRooms = numRooms;
            FrontDoor = frontDoor;
            MainKitchen = mainKitchen;
        }

        public override int GetRooms()
        {
            return NumRooms;
        }

        public override string ToString()
        {
            return $"House - Rooms: {NumRooms}, Front Door: {FrontDoor}, Main Kitchen: {MainKitchen}";
        }
    }
}