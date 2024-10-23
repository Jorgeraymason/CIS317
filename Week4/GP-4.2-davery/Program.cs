/*******************************************************************
* Name: Devin Avery
* Date: 10/21/2024
* Assignment: SDC320 Week 4 GP – Text Files
*
* Main application class.
*/
using System.IO;
public class TextFileDemo
{
    private const string FILE_NAME = "YourName.txt";
    public static void Main(string[] args)
    {
        Console.WriteLine("\nDevin Avery, Week 4 Text Files GP\n");
        Console.WriteLine(WriteToFile());
        Console.WriteLine(ReadFromFile());
    }
    // Write to a file - return a message indicating success
    private static string WriteToFile()
    {
        //Write text to a file; if the file doesn't exist, it will be created;
        //if it does exist, it will be overwritten
        File.WriteAllText(FILE_NAME, "Hello Devin Avery!" + Environment.NewLine);
        //Append text to a file; if the file doesn't exist it will be created
        File.AppendAllText(FILE_NAME,
        "You just wrote 2 lines of text to a file!");
        return "Successfully wrote to the file.";
    }
    // Read from a file - return a message indicating the file contents were
    // printed
    private static string ReadFromFile()
    {
        //Read all the lines from the named file into a string array
        string[] readText = File.ReadAllLines(FILE_NAME);
        //print each line from the file to the console
        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }
        return "All lines from file printed!";
    }
}