using System;

namespace _04._Workout
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());

            double totalDistance = distance;

            for (int i = 1; i <= days; i++)
            {
                double increase = double.Parse(Console.ReadLine()) / 100;
                distance += increase * distance;
                totalDistance += distance;
            }

            if (totalDistance >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalDistance - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalDistance)} more kilometers");
            }
        }
    }
}
