using System;

namespace _03._Lucky_Numbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int temp = 0;
            int first = 0;
            int second = 0;

            if (num > 9)
            {
                temp = 9;
            }
            else
            {
                temp = num;
            }
            for (int i = 1; i <= temp; i++)
            {
                for (int j = 1; j <= temp; j++)
                {
                    first = i + j;
                    for (int h = 1; h <= temp; h++)
                    {
                        for (int z = 1; z <= temp; z++)
                        {
                            second = h + z;
                            if (first == second & num % first == 0)
                            {
                                Console.Write($"{i}{j}{h}{z} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
