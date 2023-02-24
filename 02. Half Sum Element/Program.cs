using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;

            for (int i = 0; i < num; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                sum = sum + temp;
                if (temp > max)
                {
                    max = temp;
                }
            }
            sum = sum - max;
            if ( sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - sum)}");
            }
        }
    }
}
