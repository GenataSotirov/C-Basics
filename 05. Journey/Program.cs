using System;

namespace _05._Journey
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double money = 0;   
            string place = "";

            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        destination = "Bulgaria";
                        money = budget * 0.3;
                        place = "Camp";
                        break;
                    case "winter":
                        destination = "Bulgaria";
                        money = budget * 0.7;
                        place = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            else if (budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        destination = "Balkans";
                        money = budget * 0.4;
                        place = "Camp";
                        break;
                    case "winter":
                        destination = "Balkans";
                        money = budget * 0.8;
                        place = "Hotel";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                destination = "Europe";
                money = budget * 0.9;
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {money:f2}");
        }
    }
}
