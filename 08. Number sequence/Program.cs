using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int numMin = int.MaxValue;
            int numMax = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                int tempOne = temp;
                int tempTwo = temp;
                if (tempOne < numMin)
                {
                    numMin = temp;
                }
                if (tempTwo > numMax)
                {
                    numMax = temp;
                }
            }
            Console.WriteLine($"Max number: {numMax}");
            Console.WriteLine($"Min number: {numMin}");
        }
    }
}
