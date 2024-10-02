/*******************************************************************
* Name: Devin Avery
* Date: 9/30/2024
* Assignment: SDC320 Week 1 GP – Inheritance
*
* This class represents a Student object, which is "ultimate" base
* class in this exercise. All other classes are derived from this
* class at some level. This class includes Name and SchoolName
* properties. The constructor takes parameters to set all properties.
* ToString is overridden and calls the GetStudentInformation method to
* provide the formatted data.
*/

public class Student
{
    //Class properties
    public string Name { get; set; }
    public string SchoolName { get; set; }
    //2-parameter constructor to set the class properties
    public Student(string name, string school)
    {
        Name = name;
        SchoolName = school;
    }
    //Return the student information formatted as:
    //Student Name: Name
    //School Name: SchoolName
    
    //Note the use of "virtual" - this allows child classes to override
    //the method
    public virtual string GetStudentInformation()
    {
        return string.Format("Student Name: {0}\nSchool Name: {1}",
        Name, SchoolName);
    }
    //Override the ToString() method so if someone wants the
    //string representation of this class, they get the
    //formatted student information
    public override string ToString()
    {
        return GetStudentInformation();
    }
}