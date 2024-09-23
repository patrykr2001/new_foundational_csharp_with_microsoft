namespace create_and_run_simple_csharp_console_applications;

public static class Cwiczenie3
{
    public static void Run()
    {
        // Zad 1
        /*string[] fraudulentOrderIDs = new string[3];

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        // fraudulentOrderIDs[3] = "D000";*/
        
        string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
        
        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
        
        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        
        // Zad 2
        
        string[] names = { "Rowena", "Robin", "Bao" };
        
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        
        int[] inventory = [200, 450, 700, 175, 250];
        int sum = 0;
        int bin = 0;
        
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        
        Console.WriteLine($"We have {sum} items in inventory.");
    }
}