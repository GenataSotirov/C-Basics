using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            int night = days - 1;
            double price = 0;

            if (room == "room for one person")
            {
                price = night * 18;
            }
            else if (room == "apartment")
            {
                price = night * 25;
                if (days < 10)
                {
                    price = price - price * 0.3;
                }
                else if (days > 15)
                {
                    price = price - price * 0.5;
                }
                else
                {
                    price = price - price * 0.35;
                }
            }
            else if (room == "president apartment")
            {
                price = night * 35;
                if (days < 10)
                {
                    price = price - price * 0.1;
                }
                else if (days > 15)
                {
                    price = price - price * 0.2;
                }
                else
                {
                    price = price - price * 0.15;
                }
            }
            if (rating == "positive")
            {
                price = price + price * 0.25;
            }
            else
            {
                price = price - price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
