using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main()
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int night = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = string.Empty;

            if (season == "Winter")
            {
                if (groupType == "mixed")
                {
                    price = count * 10 * night;
                    sport = "Ski";
                }
                else if (groupType == "girls")
                {
                    price = count * 9.6 * night;
                    sport = "Gymnastics";
                }
                else 
                {
                    price = count * 9.6 * night;
                    sport = "Judo";
                }
            }
            else if (season == "Summer")
            {
                if (groupType == "mixed")
                {
                    price = count * 20 * night;
                    sport = "Swimming";
                }
                else if (groupType == "girls")
                {
                    price = count * 15 * night;
                    sport = "Volleyball";
                }
                else
                {
                    price = count * 15 * night;
                    sport = "Football";
                }
            }
            else
            {
                if (groupType == "mixed")
                {
                    price = count * 9.5 * night;
                    sport = "Cycling";
                }
                else if (groupType == "girls")
                {
                    price = count * 7.2 * night;
                    sport = "Athletics";
                }
                else
                {
                    price = count * 7.2 * night;
                    sport = "Tennis";
                }
            }
            if (count >= 10 && count < 20)
            {
                price = price - price * 0.05;
            }
            else if (count < 50 && count >= 20)
            {
                price = price - price * 0.15;
            }
            else if (count >= 50)
            {
                price = price - price * 0.5;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
