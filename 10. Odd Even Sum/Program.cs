using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= num; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if (i%2==1)
                {
                    sumOdd = sumOdd + temp;
                }
                else
                {
                    sumEven = sumEven + temp;
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOdd - sumEven)}");
            }
        }
    }
}
