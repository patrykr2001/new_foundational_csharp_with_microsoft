namespace dodawanie_logiki_do_aplikacji_jezyka_csharp;

public static class Cwiczenie5
{
    public static void Run()
    {
        Random random = new Random();
        int current = random.Next(1, 11);

        /*
        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);
        */

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");
    }
}