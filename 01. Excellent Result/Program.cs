using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main()
        {
            double rating = double.Parse(Console.ReadLine());
            if (rating >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
