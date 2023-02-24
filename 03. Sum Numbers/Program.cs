using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < number)
            {
                int temp = int.Parse(Console.ReadLine());
                sum += temp;
            }
            Console.WriteLine(sum);
        }
    }
}
