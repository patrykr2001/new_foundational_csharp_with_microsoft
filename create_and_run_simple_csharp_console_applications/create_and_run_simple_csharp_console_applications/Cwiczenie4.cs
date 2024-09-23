namespace create_and_run_simple_csharp_console_applications;

public static class Cwiczenie4
{
    public static void Run()
    {
        /*
        The following code creates five random OrderIDs
        to test the fraud detection process.  OrderIDs
        consist of a letter from A to E, and a three-
        digit number. Ex. A123.
        */
        Random random = new Random();
        string[] orderIDs = new string[5];

        for (int i = 0; i < orderIDs.Length; i++)
        {
            int prefixValue = random.Next(65, 70);
            string prefix = Convert.ToChar(prefixValue).ToString();
            string suffix = random.Next(1, 1000).ToString("000");

            orderIDs[i] = prefix + suffix;
        }

        foreach (var orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }
        
        // Example 1:
        Console
            .
            WriteLine
            (
                "Hello Example 1!"
            )
            ;

        // Example 2:
        string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");
        
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
            if ((roll1 == roll2) && (roll2 == roll3)) {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6; 
            } else {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
        }
        
        /*
        This code reverses a message, counts the number of times
        a particular character appears, then prints the results
        to the console window.
        */

        string originalMessage = "The quick brown fox jumps over the lazy dog.";

        char[] message = originalMessage.ToCharArray();
        Array.Reverse(message);

        int letterCount = 0;

        foreach (char letter in message)
        {
            if (letter == 'o')
            {
                letterCount++;
            }
        }

        string newMessage = new String(message);

        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {letterCount} times.");
    }
}