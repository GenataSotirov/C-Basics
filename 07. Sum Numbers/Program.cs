using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}
