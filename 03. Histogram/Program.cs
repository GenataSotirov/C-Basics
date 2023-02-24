using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double pOne = 0;
            double pTwo = 0;
            double pThree = 0;
            double pFour = 0;
            double pFive =0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    pOne++;
                }
                else if (num < 400)
                {
                    pTwo++;
                }
                else if (num < 600)
                {
                    pThree++;
                }
                else if (num < 800)
                {
                    pFour++;
                }
                else
                {
                    pFive++;
                }
            }
            Console.WriteLine($"{(pOne / n) * 100:f2}%");
            Console.WriteLine($"{(pTwo / n) * 100:f2}%");
            Console.WriteLine($"{(pThree / n) * 100:f2}%");
            Console.WriteLine($"{(pFour / n) * 100:f2}%");
            Console.WriteLine($"{(pFive / n) * 100:f2}%");
        }
    }
}
