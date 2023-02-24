using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            int sumVideo = videoCard * 250;
            double sumProcesor = procesors * sumVideo * 0.35;
            double sumRam = ram * sumVideo * 0.1;

            double totalSum = sumVideo + sumProcesor + sumRam;

            if (videoCard > procesors)
            {
                totalSum = totalSum - totalSum * 0.15;
            }
            //totalSum = Math.Round(totalSum, 2);
            if (totalSum > budget)
            {
                Console.Write("Not enough money! You need ");
                Console.Write("{0:f2}", totalSum - budget);
                Console.WriteLine(" leva more!");
            }
            else
            {
                Console.Write("You have ");
                Console.Write("{0:f2}", budget - totalSum);
                Console.WriteLine(" leva left!");
            }
        }
    }
}
