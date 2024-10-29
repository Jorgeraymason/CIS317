/*******************************************************************
* Name: Devin Avery
* Date: 10/28/24
* Assignment: SDC320 Week 4 PA – Database Interactions
*/
//Main program that prints and displays all addresses in the database
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Testing Database Operations");

        string db_name = "AddressDatabase.db";
        var dbManager = new DatabaseManager(db_name);

        // Populating the database with dummy data
        dbManager.AddAddress(new Address("123 Main St", "", "CityA", "StateX", "12345"));
        dbManager.AddAddress(new Address("456 Elm St", "", "CityB", "StateY", "23456"));
        dbManager.AddAddress(new Address("789 Oak St", "", "CityC", "StateZ", "34567"));
        dbManager.AddAddress(new Address("101 Pine St", "", "CityD", "StateW", "45678"));

        // Display all addresses in the database
        dbManager.PrintAllAddresses();

        // Retrieving an address by ID and updating it
        // Address updatedAddress = dbManager.GetAddressByID(2);
        // if (updatedAddress != null)
        // {
        //     updatedAddress.City = "UpdatedCity";
        //     dbManager.UpdateAddress(updatedAddress);
        // }

        // Display all addresses after the update
        //dbManager.PrintAllAddresses();

        // Deleting an address
        // dbManager.DeleteAddress(3);

        // Display all addresses after the deletion
        //dbManager.PrintAllAddresses();
    }
}