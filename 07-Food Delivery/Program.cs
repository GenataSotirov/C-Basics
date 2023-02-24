using System;

namespace _07_Food_Delivery
{
    class Program
    {
        static void Main()
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double foodPrice = chicken * 10.35 + fish * 12.40 + vegan * 8.15;
            double desert = foodPrice * 20 / 100;
            double order = foodPrice + desert + 2.50;

            Console.WriteLine(order);
        }
    }
}
