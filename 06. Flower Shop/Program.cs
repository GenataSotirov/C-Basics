using System;

namespace _06._Flower_Shop
{
    class Program
    {
        static void Main()
        {
            double magnolias = double.Parse(Console.ReadLine()) * 3.25;
            double hyacinths = double.Parse(Console.ReadLine()) * 4;
            double roses = double.Parse(Console.ReadLine()) * 3.50;
            double cactus = double.Parse(Console.ReadLine()) * 8;
            double present = double.Parse(Console.ReadLine());

            double income = magnolias + hyacinths + roses + cactus;
            double afterTax = income - income * 0.05;

            if (afterTax >= present)
            {
                Console.WriteLine($"She is left with {Math.Floor(afterTax - present)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(present - afterTax)} leva.");
            }
        }
    }
}
