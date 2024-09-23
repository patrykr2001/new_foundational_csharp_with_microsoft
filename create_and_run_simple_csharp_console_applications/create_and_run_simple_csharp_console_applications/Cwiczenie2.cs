namespace create_and_run_simple_csharp_console_applications;

public static class Cwiczenie2
{
    public static void Run()
    {
        var dice = new Random();

        var roll1 = dice.Next(1, 7);
        var roll2 = dice.Next(1, 7);
        var roll3 = dice.Next(1, 7);

        var total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
        
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
            
            Console.WriteLine($"Your total including the bonus: {total}");
        }
        
        /*if (total >= 15)
        {
            Console.WriteLine("You win!");
        }
        else 
        {
            Console.WriteLine("Sorry, you lose.");
        }*/
        
        if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }
        
        /*var message = "The quick brown fox jumps over the lazy dog.";
        var result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }*/
    }
}