using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int totalCargo = 0;
            int countBus = 0;
            int countTruck = 0; 
            int countTrain = 0;
            int price = 0;

            for (int i = 1; i <= count; i++)
            {
                int cargo = int.Parse(Console.ReadLine());
                totalCargo += cargo;

                if (cargo <= 3)
                {
                    countBus += cargo;
                    price = price + cargo * 200;
                }
                else if (cargo <= 11)
                {
                    countTruck += cargo;
                    price = price + cargo * 175;
                }                                                    
                else                             
                {
                    countTrain += cargo;
                    price = price + cargo * 120;
                }
            }
            Console.WriteLine($"{(double)price / totalCargo:f2}");
            Console.WriteLine($"{((double)countBus / totalCargo) * 100:f2}%");
            Console.WriteLine($"{((double)countTruck / totalCargo) * 100:f2}%");
            Console.WriteLine($"{((double)countTrain / totalCargo) * 100:f2}%");
        }
    }
}
