using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string type = string.Empty;
            string car = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                type = "Economy class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    car = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                type = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    car = "Jeep";
                    price = budget * 0.8;
                }
            }
            else
            {
                type = "Luxury class";
                car = "Jeep";
                price = budget * 0.9;
            }
            Console.WriteLine(type);
            Console.WriteLine($"{car} - {price:f2}");
        }
    }
}
