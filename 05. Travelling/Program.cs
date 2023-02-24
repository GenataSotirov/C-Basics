using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main()
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                while (minBudget > 0)
                {
                    double saveMoney = double.Parse(Console.ReadLine());
                    minBudget -= saveMoney;
                    if (minBudget <= 0)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
                destination = Console.ReadLine();
            }
        }
    }
}
