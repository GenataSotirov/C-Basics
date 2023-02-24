using System;
using System.Diagnostics;

namespace _05._Small_Shop
{
    class Program
    {
        static void ChoiseProduct(string product, double[] arr, double volume)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = volume * arr[0];
                    Console.WriteLine(price);
                    break;
                case "water":
                    price = volume * arr[1];
                    Console.WriteLine(price);
                    break;
                case "beer":
                    price = volume * arr[2];
                    Console.WriteLine(price);
                    break;
                case "sweets":
                    price = volume * arr[3];
                    Console.WriteLine(price);
                    break;
                case "peanuts":
                    price = volume * arr[4];
                    Console.WriteLine(price);
                    break;
                default:
                    break;
            }
        }
        static void Main()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());

            double[] sofia = { 0.50, 0.80, 1.2, 1.45, 1.6 };
            double[] plovdiv = { 0.40, 0.70, 1.15, 1.30, 1.50 };
            double[] varna = {0.45, 0.70, 1.10, 1.35, 1.55 };

            if (city == "Sofia")
            {
                ChoiseProduct(product, sofia, volume);
            }
            else if (city == "Plovdiv")
            {
                ChoiseProduct(product, plovdiv, volume);
            }
            else
            {
                ChoiseProduct(product, varna, volume);
            }
        }
    }
}
