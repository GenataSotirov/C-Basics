using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main()
        {
            string season = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());

            double money = 0;

            if (distance <= 5000)
            {
                if (season == "Summer")
                {
                    money = 4 * distance * 0.9;
                }
                else if (season == "Winter")
                {
                    money = 4 * distance * 1.05;
                }
                else
                {
                    money = 4 * distance * 0.75;
                }
            }
            else if (distance <= 10000)
            {
                if (season == "Summer")
                {
                    money = 4 * distance * 1.1;
                }
                else if (season == "Winter")
                {
                    money = 4 * distance * 1.25;
                }
                else
                {
                    money = 4 * distance * 0.95;
                }
            }
            else
            {
                money = 4 * distance * 1.45;
            }
            money = money - money * 0.1;
            Console.WriteLine($"{money:f2}");
        }
    }
}
