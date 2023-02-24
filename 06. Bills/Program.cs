using System;

namespace _06._Bills
{
    class Program
    {
        static void Main()
        {
            int months = int.Parse(Console.ReadLine());
            double current = 0;
            double electricity = 0;
            double water = 0;
            double internet = 0;
            double other = 0;

            for (int i = 1; i <= months; i++)
            {
                current = double.Parse(Console.ReadLine());
                electricity += current;
                water += 20;
                internet += 15;
                other += (current + 20 + 15) * 1.2;
            }
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {(electricity+water+internet+other)/months:f2} lv");
        }
    }
}
