public class Student
{
    private int ID;
    private string name;
    private static string college = "BBDIT";

    //constructor to initialize the variable
    public Student(int id, string n)
    {
        ID = id;
        name = n;
    }

    //static method to change the value of static variable

    public static void Change()
    {
        college = "International University";
    }

    //method to display values
    public void Display()
    {
        Console.WriteLine(ID + " " + name + " " + college);
    }
}