using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishMan = int.Parse(Console.ReadLine());

            double shipRent = 0;

            if (season == "Spring")
            {
                if (fishMan <= 6)
                {
                    shipRent = 3000 - 3000 * 0.1;
                }
                else if (fishMan <= 11)
                {
                    shipRent = 3000 - 3000 * 0.15;
                }
                else
                {
                    shipRent = 3000 - 3000 * 0.25;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (fishMan <= 6)
                {
                    shipRent = 4200 - 4200 * 0.1;
                }
                else if (fishMan <= 11)
                {
                    shipRent = 4200 - 4200 * 0.15;
                }
                else
                {
                    shipRent = 4200 - 4200 * 0.25;
                }
            }
            else if (season == "Winter")
            {
                if (fishMan <= 6)
                {
                    shipRent = 2600 - 2600 * 0.1;
                }
                else if (fishMan <= 11)
                {
                    shipRent = 2600 - 2600 * 0.15;
                }
                else
                {
                    shipRent = 2600 - 2600 * 0.25;
                }
            }
            if (fishMan % 2 == 0 && season != "Autumn" )
            {
                shipRent = shipRent - shipRent * 0.05;
            }
            if (shipRent <= budget)
            {
                Console.WriteLine($"Yes! You have {(budget - shipRent):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(shipRent - budget):f2} leva.");
            }
        }
    }
}
