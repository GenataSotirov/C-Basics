using System;

namespace _10._Multiply_by_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (num >= 0)
            {
                double result = num * 2;
                Console.WriteLine($"Result: {result:f2}");
                num = double.Parse(Console.ReadLine());
            }
            if (num < 0)
            {
                Console.WriteLine("Negative number!");
            }
            
        }
    }
}
