using System;

namespace _10._Diamond
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftSide = (n - 1) / 2;
            int rightSide = n / 2;

            for (int row = 0; row < (n - 1) / 2; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == leftSide || col == rightSide)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
                leftSide--;
                rightSide++;
            }
            leftSide = 1;
            rightSide = n - 2;

            if (n > 1)
            {
                Console.Write("*");
                Console.Write(new string('-', n - 2));
                Console.WriteLine("*");
            }
            else
            {
                Console.WriteLine("*");
            }

            for (int row = 0; row < (n - 1) / 2; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == leftSide || col == rightSide)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
                leftSide++;
                rightSide--;
            }
        }
    }
}
