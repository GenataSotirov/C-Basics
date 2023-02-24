using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count = 0;
            double payCard = 0;
            double payKash = 0;
            int countCard = 0;
            int countKash = 0;

            while (input != "End")
            {
                bool isGood = int.TryParse(input, out int money );
                if (!isGood)
                {
                    input = Console.ReadLine();
                    continue;
                }
                count++;
                if (count%2==1 && money <= 100)
                {
                    Console.WriteLine("Product sold!");
                    sum -= money;
                    countKash++;
                    payKash += money;
                }
                else if (count%2==0 && money >= 10)
                {
                    Console.WriteLine("Product sold!");
                    sum -= money;
                    countCard++;
                    payCard += money;
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                    input = Console.ReadLine();
                    continue;
                }
                if (sum <= 0)
                {
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }
            }
            if (input == "End" && sum > 0)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {payKash/countKash:f2}");
                Console.WriteLine($"Average CC: {payCard/countCard:f2}");
            }
        }
    }
}


