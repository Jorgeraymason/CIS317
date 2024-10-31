/// Author: Devin Avery
/// Date: Date of development
/// Assignment: SDC320 Final Practical
/// Description: Abstract base class representing a building.
using System;

namespace devave9719_FINAL_PROJECT
{
    public abstract class Building
    {
        private string BuildingType;

        protected Building(string buildingType)
        {
            BuildingType = buildingType;
        }

        public abstract int GetRooms();

        public override string ToString()
        {
            return $"Building Type: {BuildingType}";
        }
    }
}