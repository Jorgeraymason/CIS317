/*******************************************************************
* Name: Devin Avery
* Date: 9/30/24
* Assignment: SDC320 Week 1 GP – Inheritance
*
* This class represents a CollegeStudent object, which is derived
* from the Student class by adding the student's major. A constructor
* to set all class and base class properties is provided. ToString
* is overridden and calls the base class ToString method to get the
* formatted properties. The GetStudentInformation method is also
* overridden in the same manner.
*/
public class CollegeStudent : Student
{
    public string Major { get; set; }
    //3-parameter constructor to set the parent and this class's properties
    public CollegeStudent(string name, string school, string major)
    : base(name, school)
    {
        Major = major;
    }
    public override string GetStudentInformation()
    {
        return string.Format("{0}\nStudent Major: {1}",
        base.GetStudentInformation(), Major);
    }
    public override string ToString()
    {
        return string.Format("{0}\nStudent Major: {1}",
        base.ToString(), Major);
    }
}