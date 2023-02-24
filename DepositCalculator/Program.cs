using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main()
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double dividend = double.Parse(Console.ReadLine());

            double dividendPerYear = deposit * (dividend / 100);
            double total = deposit + (dividendPerYear / 12) * months;
            Console.WriteLine(total);
        }
    }
}
