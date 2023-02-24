using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main()
        {
            int seaTrip = int.Parse(Console.ReadLine());
            int mountainTrip = int.Parse(Console.ReadLine());

            int count = seaTrip + mountainTrip;
            string input = Console.ReadLine();
            int totalSum = 0;

            while (input != "Stop" && count > 0)
            {
                if (input == "sea" && seaTrip > 0)
                {
                    if (seaTrip > 0)
                    {
                        seaTrip--;
                        totalSum += 680;
                    }
                }
                else if (input == "mountain" && mountainTrip > 0)
                {
                    if (mountainTrip > 0)
                    {
                        mountainTrip--;
                        totalSum += 499;
                    }
                }
                count = seaTrip + mountainTrip;
                if (count > 0)
                {
                    input = Console.ReadLine();
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {totalSum} leva.");
        }
    }
}
