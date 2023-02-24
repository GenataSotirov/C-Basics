using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
