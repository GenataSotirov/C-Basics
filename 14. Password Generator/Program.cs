using System;

namespace _14._Password_Generator
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    
                    for (int k = 97; k < 97 + l; k++)
                    {
                        for (int h = 97; h < 97 + l; h++)
                        {
                            for (int f = 2; f <= n; f++)
                            {
                                char first = (char)k;
                                char second = (char)h;
                                if (f > i && f > j)
                                {
                                    Console.Write($"{i}{j}{first}{second}{f} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
