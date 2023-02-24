using System;

namespace _11._Odd_Even_Position
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            if (n == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                bool more = false;
                for (int i = 1; i <= n; i++)
                {
                    double num = double.Parse(Console.ReadLine());

                    if (n==1)
                    {
                        Console.WriteLine($"OddSum={num:f2},");
                        Console.WriteLine($"OddMin={num:f2},");
                        Console.WriteLine($"OddMax={num:f2},");
                        Console.WriteLine($"EvenSum={evenSum:f2},");
                        Console.WriteLine($"EvenMin=No,");
                        Console.WriteLine($"EvenMax=No");
                        more = true;
                    }
                    else
                    {
                        if (i % 2 == 1)
                        {
                            oddSum += num;
                            if (num < oddMin)
                            {
                                oddMin = num;
                            }
                            if (num > oddMax)
                            {
                                oddMax = num;
                            }
                        }
                        else
                        {
                            evenSum += num;
                            if (num < evenMin)
                            {
                                evenMin = num;
                            }
                            if (num > evenMax)
                            {
                                evenMax = num;
                            }
                        }
                    }
                }
                if (!more)
                {
                    Console.WriteLine($"OddSum={oddSum:f2},");
                    Console.WriteLine($"OddMin={oddMin:f2},");
                    Console.WriteLine($"OddMax={oddMax:f2},");
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin={evenMin:f2},");
                    Console.WriteLine($"EvenMax={evenMax:f2}");
                }
            }
        }
    }
}
