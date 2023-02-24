using System;

namespace _03._New_House
{
    class Program
    {
        static void Main()
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double sum = 0;
            if (flowers == "Roses")
            {
                if (count > 80)
                {
                    sum = count * 5;
                    sum = sum - sum * 0.1;
                }
                else
                {
                    sum = count * 5;
                }
            }
            else if (flowers == "Dahlias")
            {
                if (count > 90)
                {
                    sum = count * 3.80;
                    sum = sum - sum * 0.15;
                }
                else
                {
                    sum = count * 3.80;
                }
            }
            else if (flowers == "Tulips")
            {
                if (count > 80)
                {
                    sum = count * 2.80;
                    sum = sum - sum * 0.15;
                }
                else
                {
                    sum = count * 2.80;
                }
            }
            else if (flowers == "Narcissus")
            {
                if (count < 120)
                {
                    sum = count * 3;
                    sum = sum + sum * 0.15;
                }
                else
                {
                    sum = count * 3;
                }
            }
            else if (flowers == "Gladiolus")
            {
                if (count < 80)
                {
                    sum = count * 2.50;
                    sum = sum + sum * 0.2;
                } 
                else
                {
                    sum = count * 2.50;
                }       
            }
            if (sum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {(budget - sum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(sum - budget):f2} leva more.");
            }
        }
    }
}
