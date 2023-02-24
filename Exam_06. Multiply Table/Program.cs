using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int a = num % 10;
            num /= 10;
            int b = num % 10;
            int c = num / 10;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    for (int l = 1; l <= c; l++)
                    {
                        Console.WriteLine($"{i} * {j} * {l} = {i*j*l};");
                    }
                }
            }
        }
    }
}
