using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < num; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + temp;
            }
            for (int i = 0; i < num; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                sumRight = sumRight + temp;
            }
            if (sumRight == sumLeft)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}
