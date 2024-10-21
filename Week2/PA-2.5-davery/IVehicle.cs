/*******************************************************************
* Name: Devin Avery
* Date: 10/9/2024
* Assignment: SDC320 Week 2 PA – Interface
*
* Interface class IAnimal - defines all methods that classes that
* implement this interface must implement.
*/

using System;

public interface IVehicle
{
    void Start();
    void Stop();
    void Drive(string destination);
}