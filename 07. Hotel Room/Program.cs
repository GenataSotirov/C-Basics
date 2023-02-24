using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApart = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = days * 50;
                    priceApart = days * 65;
                    if (days > 14)
                    {
                        priceApart = priceApart - priceApart * 0.1;
                        priceStudio = priceStudio - priceStudio * 0.3;
                    }
                    else if (days > 7)
                    {
                        priceStudio = priceStudio - priceStudio * 0.05;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = days * 75.20;
                    priceApart = days * 68.70;
                    if (days > 14)
                    {
                        priceApart = priceApart - priceApart * 0.1;
                        priceStudio = priceStudio - priceStudio * 0.2;
                    }
                    break;
                case "July":
                case "August":
                    priceStudio = days * 76;
                    priceApart = days * 77;
                    if (days > 14)
                    {
                        priceApart = priceApart - priceApart * 0.1;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Apartment: { priceApart:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
