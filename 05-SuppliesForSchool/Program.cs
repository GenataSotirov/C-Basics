using System;

namespace _05_SuppliesForSchool
{
    class Program
    {
        static void Main()
        {
            int pencil = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int gel = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double sum = pencil * 5.80 + marker * 7.20 + gel * 1.20;
            double final = sum - sum * discount / 100;

            Console.WriteLine(final);
        }
    }
}
