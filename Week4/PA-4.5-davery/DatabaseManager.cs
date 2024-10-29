//Database Management code for database that handles addresses.
using System;
using System.Data.SQLite;

public class DatabaseManager
{
    private SQLiteConnection connection;

    public DatabaseManager(string db_name)
    {
        connection = new SQLiteConnection($"Data Source={db_name};Version=3;");
        connection.Open();
        CreateTable();
    }

    private void CreateTable()
    {
        string createTableQuery = @"CREATE TABLE IF NOT EXISTS Addresses (
                                        ID INTEGER PRIMARY KEY,
                                        Street_Address1 TEXT,
                                        Street_Address2 TEXT,
                                        City TEXT,
                                        State TEXT,
                                        Zip_Code TEXT)";
        using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
        {
            command.ExecuteNonQuery();
        }
    }

    public void AddAddress(Address address)
    {
        string insertQuery = @"INSERT INTO Addresses (Street_Address1, Street_Address2, City, State, Zip_Code)
                               VALUES (@Street_Address1, @Street_Address2, @City, @State, @Zip_Code)";
        using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
        {
            command.Parameters.AddWithValue("@Street_Address1", address.Street_Address1);
            command.Parameters.AddWithValue("@Street_Address2", address.Street_Address2);
            command.Parameters.AddWithValue("@City", address.City);
            command.Parameters.AddWithValue("@State", address.State);
            command.Parameters.AddWithValue("@Zip_Code", address.Zip_Code);
            command.ExecuteNonQuery();
        }
    }

    public void PrintAllAddresses()
    {
        string selectQuery = "SELECT * FROM Addresses";
        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
        {
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["ID"]}, Street Address 1: {reader["Street_Address1"]}, Street Address 2: {reader["Street_Address2"]}, City: {reader["City"]}, State: {reader["State"]}, Zip Code: {reader["Zip_Code"]}");
                }
            }
        }
    }

    // Implement other methods like GetAddressByID, UpdateAddress, DeleteAddress
}