using System;

namespace _02._Football_Kit
{
    class Program
    {
        static void Main()
        {
            double priceTshirt = double.Parse(Console.ReadLine());
            double targetPrice = double.Parse(Console.ReadLine());

            double priceShort = priceTshirt * 0.75;
            double priceSocks = priceShort * 0.2;
            double priceButton = (priceTshirt + priceShort) * 2;

            double totalPrice = priceTshirt +priceShort + priceSocks + priceButton;
            totalPrice -= totalPrice * 0.15;

            if (totalPrice >= targetPrice)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {targetPrice - totalPrice:f2} lv. more.");
            }
        }
    }
}
