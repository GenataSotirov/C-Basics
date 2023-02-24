using System;

namespace _05._Pets
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int foods = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine()) / 1000;

            double neededFood = (dogFood + catFood + turtleFood) * days;

            if (foods >= neededFood)
            {
                double leftFood = Math.Floor(foods - neededFood);
                Console.WriteLine($"{leftFood} kilos of food left.");
            }
            else
            {
                double missFood = Math.Ceiling(neededFood - foods);
                Console.WriteLine($"{missFood} more kilos of food are needed.");
            }
        }
    }
}
