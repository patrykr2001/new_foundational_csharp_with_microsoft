namespace create_and_run_simple_csharp_console_applications;

class Program
{
    static void Main(string[] args)
    {
        var dice = new Random();
        var roll = dice.Next(1, 7);
        Console.WriteLine($"Roll: {roll}");
        
        var number = 7;
        var text = "seven";

        Console.WriteLine();
        Console.WriteLine(number);
        Console.WriteLine(text);
        
        var roll1 = dice.Next();
        var roll2 = dice.Next(101);
        var roll3 = dice.Next(50, 101);

        Console.WriteLine();
        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
        
        var firstValue = 500;
        var secondValue = 600;

        var largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine(largerValue);
    }
}