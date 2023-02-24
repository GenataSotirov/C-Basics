using System;

namespace _01._Christmas_Preparation
{
    class Program
    {
        static void Main()
        {
            int paper = int.Parse(Console.ReadLine());
            int cloth = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()) / 100;

            double pricePaper = paper * 5.8;
            double priceCloth = cloth * 7.2;
            double priceGlue = glue * 1.2;

            double total = pricePaper + priceCloth + priceGlue;
            total -= total * discount;

            Console.WriteLine($"{total:f3}");
        }
    }
}
