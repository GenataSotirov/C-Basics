using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int h = start; h <= end; h++)
                    {
                        for (int z = start; z <= end; z++)
                        {
                            if (i%2==0 && i > z && z%2==1 && (j+h)%2==0)
                            {
                                Console.Write($"{i}{j}{h}{z} ");
                            }
                            else if (i % 2 == 1 && i > z && z % 2 == 0 && (j + h) % 2 == 0)
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
