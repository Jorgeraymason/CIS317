/*******************************************************************
* Name: Devin Avery
* Date:
* Assignment: SDC320 Week 2 GP – Interface
*
* Interface class IAnimal - defines all methods that classes that
* implement this interface must implement.
*/
interface IAnimal
{
    string GetName();
    string MakeSound();
    void Move(string start, string end);
}