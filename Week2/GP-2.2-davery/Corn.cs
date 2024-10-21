/*******************************************************************
* Name: Devin Avery
* Date: 10/7/2024
* Assignment: SDC320 Week 2 GP – Polymorphism
*
* Derived from the Vegetable class. Override of ToString() provided for
* formatted output of class information. All properties are public
* with get and set accessors. Constructor sets all properties to
* provided values.
*/
public class Corn : Vegetable
{
    public string Variety { get; set; }
    public string Packaging { get; set; }
    //Note that the "name" parameter is ommitted from the constructor
    //choosing rather to pass a custom name into the base constructor
    //based on other information unique to this class
    public Corn(string servingSize, string plantingSeason,
    string harvestSeason, string variety, string packaging)
    : base(variety + " Corn", servingSize, plantingSeason, harvestSeason)
    {
        Variety = variety;
        Packaging = packaging;
    }
    public override string ToString()
    {
        return string.Format(
        "{0}Type of Corn: {1}\nPackage Description: {2}\n",
        base.ToString(), Variety, Packaging);
    }
}