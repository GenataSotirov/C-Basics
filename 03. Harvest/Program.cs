using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = area * grapes;
            double wine = (totalGrapes * 0.4) / 2.5;

            if (wine < liters)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(liters - wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - liters)} liters left -> {Math.Ceiling((wine - liters) / workers)} liters per person.");
            }
        }
    }
}
