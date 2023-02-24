using System;

namespace _09._House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == 1 && n % 2 == 0)
                    {
                        if (col <= n/2-1)
                        {
                            Console.Write("-");
                        }
                        else if (col > n / 2 + 1)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("*"); 
                        }
                    }
                    if (row == 1 && n % 2 != 0)
                    {
                        if (col <= n / 2)
                        {
                            Console.Write("-");
                        }
                        else if (col > n / 2 + 1)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    if (row == 2 && n == 2)
                    {
                        Console.Write("|");
                    }
                    if (row >=2 && n >=2)
                    {
                        if (n%2 == 0)
                        {
                            if (row > n/2)
                            {
                                if (col == 1 || col == n)
                                {
                                    Console.Write("|");
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }
                            else if (col <= n / 2 - row)
                            {
                                Console.Write("-");
                            }
                            else if (col > n / 2 + row)
                            {
                                Console.Write("-");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        else
                        {
                            if (row > n/2+1)
                            {
                                if (col == 1 || col == n)
                                {
                                    Console.Write("|");
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }
                            else if (col <= n / 2 - row+1)
                            {
                                Console.Write("-");
                            }
                            else if (col > n / 2 + row)
                            {
                                Console.Write("-");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
