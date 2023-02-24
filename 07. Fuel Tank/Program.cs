using System;

namespace _07._Fuel_Tank
{
    class Program
    {
        static void Main()
        {
            string fuel = Console.ReadLine();
            string result = fuel.ToLower();
            double volume = double.Parse(Console.ReadLine());

            if (fuel != "Diesel" && fuel != "Gasoline" && fuel != "Gas")
            {
                Console.WriteLine("Invalid fuel!");
            }
            else
            {
                if (volume >= 25)
                {
                    Console.WriteLine($"You have enough {result}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {result}!");
                }
            }
        }
    }
}
