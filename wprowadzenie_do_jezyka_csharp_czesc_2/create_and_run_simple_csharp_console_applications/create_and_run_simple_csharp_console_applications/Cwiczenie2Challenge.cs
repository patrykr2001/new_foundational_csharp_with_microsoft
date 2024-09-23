namespace create_and_run_simple_csharp_console_applications;

public static class Cwiczenie2Challenge
{
    public static void Run()
    {
        var random = new Random();
        var daysUntilExpiration = random.Next(12);
        var discountPercentage = 0;

        // Your code goes here

        if (daysUntilExpiration <= 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days!");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        
        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }
    }
}