 /// Author: Devin Avery
/// Date: Date of development
/// Assignment: SDC320 Final Practical
/// Description: Represents a door object.
/// Concepts: Composition, Polymorphism, Use of Constructors
using System;

namespace devave9719_FINAL_PROJECT
{
    public class Door
    {
        private int Width;
        private string Color;

        public Door(int width, string color)
        {
            Width = width;
            Color = color;
        }

        public override string ToString()
        {
            return $"Door - Width: {Width}, Color: {Color}";
        }
    }
}