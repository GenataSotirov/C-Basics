using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string house = string.Empty;
            string location = string.Empty;
            double price = 0;

            if (budget <= 1000)
            {
                house = "Camp";
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.65;
                        location = "Alaska";
                        break;
                    case "Winter":
                        price = budget * 0.45;
                        location = "Morocco";
                        break;
                    default:
                        break;
                }
            }
            else if (budget <= 3000)
            {
                house = "Hut";
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.8;
                        location = "Alaska";
                        break;
                    case "Winter":
                        price = budget * 0.6;
                        location = "Morocco";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                house = "Hotel";
                price = budget * 0.9;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
            }
            Console.WriteLine($"{location} - {house} - {price:f2}");
        }
    }
}
