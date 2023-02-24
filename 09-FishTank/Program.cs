using System;

namespace _09_FishTank
{
    class Program
    {
        static void Main()
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideH = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = sideA * sideB * sideH;
            double waterVolume = volume - volume * percent / 100;

            Console.WriteLine(waterVolume / 1000);
        }
    }
}
