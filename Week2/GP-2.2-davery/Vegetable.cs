/*******************************************************************
* Name: Devin Avery
* Date: 10/7/2024
* Assignment: SDC320 Week 2 GP – Polymorphism
*
* Derived from the Food class and is the base class for Corn. Override
* of ToString() provided for formatted output of class information.
* All properties are public with get and set accessors. Constructor
* sets all properties to provided values.
*/
public class Vegetable : Food
{
    public string PlantingSeason { get; set; }
    public string HarvestSeason { get; set; }
    public Vegetable(string name, string servingSize, string plantingSeason,
    string harvestSeason) : base(name, servingSize)
    {
        PlantingSeason = plantingSeason;
        HarvestSeason = harvestSeason;
    }
    public override string ToString()
    {
        return string.Format(
        "{0}Planting Time: {1}\nHarvest Time: {2}\n",
        base.ToString(), PlantingSeason, HarvestSeason);
    }
}