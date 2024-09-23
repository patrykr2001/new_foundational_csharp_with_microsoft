namespace create_and_run_simple_csharp_console_applications;

public static class Cwiczenie3Challenge
{
    public static void Run()
    {
        string[] ordersIds = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

        foreach (var orderId in ordersIds)
        {
            if (orderId.StartsWith("B"))
            {
                Console.WriteLine(orderId);
            }
        }
    }
}