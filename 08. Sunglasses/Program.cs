using System;

namespace _08._Sunglasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= 5*n; col++)
                {
                    if (row == 1 || row == n)
                    {
                        if (col<=2*n || col > 3*n)
                        {
                            Console.Write("*");
                        }
                        else if (col<=3*n)
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (row == n / 2 && n%2==0)
                    {
                        if (col == 1 || col == 2 * n || col == 3 * n + 1 || col == 5 * n)
                        {
                            Console.Write("*");
                        }
                        else if (col > 2 * n && col <= 3 * n)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                    else if (row == n / 2+1 && n % 2 != 0)
                    {
                        if (col == 1 || col == 2 * n || col == 3 * n + 1 || col == 5 * n)
                        {
                            Console.Write("*");
                        }
                        else if (col > 2 * n && col <= 3 * n)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                    else if ((row > 1 && row < n) || row!=n/2)
                    {
                        if (col==1 || col == 2*n || col == 3*n+1 || col == 5*n)
                        {
                            Console.Write("*");
                        }
                        else if (col > 2*n && col <= 3 * n)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
