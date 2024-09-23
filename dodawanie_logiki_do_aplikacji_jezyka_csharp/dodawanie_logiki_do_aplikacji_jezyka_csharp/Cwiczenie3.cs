namespace dodawanie_logiki_do_aplikacji_jezyka_csharp;

public static class Cwiczenie3
{
    public static void Run()
    {
        int employeeLevel = 201;
        string employeeName = "John Smith";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
                title = "Junior Associate";
                break;
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"{employeeName}, {title}");
    }
}