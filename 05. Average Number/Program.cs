using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                sum += num;
            }
            Console.WriteLine($"{(double)sum/count:f2}");
        }
    }
}
