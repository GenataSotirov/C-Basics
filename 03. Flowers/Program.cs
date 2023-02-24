using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main()
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char weekend = char.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring" || season == "Summer")
            {
                price = chrysanthemums * 2 + roses * 4.1 + tulips * 2.5;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                price = chrysanthemums * 3.75 + roses * 4.5 + tulips * 4.15; 
            }
            if (weekend == 'Y')
            {
                price *= 1.15;
            }
            if (tulips>7 && season == "Spring")
            {
                price -= price * 0.05; 
            }
            if (roses >9 && season == "Winter")
            {
                price -= price * 0.1;
            }
            if (chrysanthemums + roses + tulips > 20)
            {
                price -= price * 0.2;
            }
            Console.WriteLine($"{2 + price:f2}");
        }
    }
}
