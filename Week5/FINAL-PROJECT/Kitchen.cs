/// Author: Devin Avery
/// Date: Date of development
/// Assignment: SDC320 Final Practical
/// Description: Represents a kitchen object.
/// Concepts: Composition, Polymorphism, Use of Constructors
using System;

namespace devave9719_FINAL_PROJECT
{
    public class Kitchen
    {
        private string Style;
        private string ApplianceBrand;

        public Kitchen(string style, string applianceBrand)
        {
            Style = style;
            ApplianceBrand = applianceBrand;
        }

        public override string ToString()
        {
            return $"Kitchen - Style: {Style}, Appliance Brand: {ApplianceBrand}";
        }
    }
}