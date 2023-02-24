using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main()
        {
            int junior = int.Parse(Console.ReadLine());
            int senior = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();

            double tax = 0;

            switch (route)
            {
                case "trail":
                    tax = junior * 5.5 + senior * 7;
                    break;
                case "cross-country":
                    tax = junior * 8 + senior * 9.5;
                    break;
                case "downhill":
                    tax = junior * 12.25 + senior * 13.75;
                    break;
                case "road":
                    tax = junior * 20 + senior * 21.50;
                    break;
                default:
                    break;
            }
            if (junior + senior >= 50 && route == "cross-country")
            {
                tax = tax - tax * 0.25;
            }
            tax = tax - tax * 0.05;
            Console.WriteLine($"{tax:f2}");
        }
    }
}
