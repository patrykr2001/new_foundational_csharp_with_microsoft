namespace Debug_CSharp_console_applications;

public class Cwiczenie1
{
    public static void Run()
    {
        string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

        int studentCount = students.Length;

        Console.WriteLine("The final name is: " + students[studentCount]);
    }
}