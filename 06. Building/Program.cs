using System;

namespace _06._Building
{
    class Program
    {
        static void Main()
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());

            for (int i = floor; i > 0; i--)
            {
                string type = "";
                if (i == floor)
                {
                    type = "L";
                }
                else if (i%2 == 1)
                {
                    type = "A";
                }
                else
                {
                    type = "O";
                }

                for (int j = 0; j < room; j++)
                {
                    Console.Write($"{type}{i}{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
