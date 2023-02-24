using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mans = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int table = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= mans; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    count++;
                    if (count <= table)
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }
                        
                }
                    
            }
        }
    }
}
