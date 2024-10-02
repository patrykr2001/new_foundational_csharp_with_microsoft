namespace Create_Methods_in_CSharp_Console_Applications;

public static class Cwiczenie4
{
    public static void Run()
    {
        string[] pettingZoo =
        [
            "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
            "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
            "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises"
        ];

        PlanSchoolVisit("School A");
        PlanSchoolVisit("School B", 3);
        PlanSchoolVisit("School C", 2);
        
        
        void PlanSchoolVisit(string schoolName, int groups = 6)
        {
            RandomizeAnimals();
            string[,] group = AssignGroup();
            Console.WriteLine("School A");
            PrintGroup(group);
        }
        
        void RandomizeAnimals() 
        {
            Random random = new Random();

            for (int i = 0; i < pettingZoo.Length; i++) 
            {
                int r = random.Next(i, pettingZoo.Length);

                (pettingZoo[i], pettingZoo[r]) = (pettingZoo[r], pettingZoo[i]);
            }
        }
        
        string[,] AssignGroup(int groups = 6) 
        {
            String[,] result = new string[groups, pettingZoo.Length/groups];
            int start = 0;

            for (int i = 0; i < groups; i++) 
            {
                for (int j = 0; j < result.GetLength(1); j++) 
                {
                    result[i,j] = pettingZoo[start++];
                }
            }

            return result;
        }
        
        void PrintGroup(string[,] group) 
        {
            for (int i = 0; i < group.GetLength(0); i++) 
            {
                Console.Write($"Group {i + 1}: ");
                for (int j = 0; j < group.GetLength(1); j++) 
                {
                    Console.Write($"{group[i,j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}