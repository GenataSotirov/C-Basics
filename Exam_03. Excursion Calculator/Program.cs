using System;

namespace _03._Excursion_Calculator
{
    class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double discount = 0;
            double price = 0;

            switch (season)
            {
                case "spring":
                    if (people <= 5)
                    {
                        price = 50;
                    }
                    else
                    {
                        price = 48;
                    }
                    break;
                case "summer":
                    if (people <= 5)
                    {
                        price = 48.5;
                    }
                    else
                    {
                        price = 45;
                    }
                    discount = 0.15;
                    break;
                case "autumn":
                    if (people <= 5)
                    {
                        price = 60;
                    }
                    else
                    {
                        price = 49.5;
                    }
                    break;
                case "winter":
                    if (people <= 5)
                    {
                        price = 86;
                    }
                    else
                    {
                        price = 85;
                    }
                    discount = 0.08;
                    break;
            }
            double total = (people * price);
            if (season == "winter")
            {
                total += total * discount;
            }
            else if (season == "summer")
            {
                total -= total * discount;
            }
            Console.WriteLine($"{total:f2} leva.");
        }
    }
}
