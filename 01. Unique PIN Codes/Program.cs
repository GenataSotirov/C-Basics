using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main()
        {
            int limitOne = int.Parse(Console.ReadLine());
            int limitTwo = int.Parse(Console.ReadLine());
            int limitThree = int.Parse(Console.ReadLine());

            for (int first = 2; first <= limitOne; first+=2)
            {
                for (int second = 2; second <= limitTwo; second++)
                {
                    if (second == 2 || second == 3 || second == 5 || second == 7)
                    {
                        for (int third = 2; third <= limitThree; third += 2)
                        {
                            Console.WriteLine($"{first} {second} {third}");
                        }
                    }
                }
            }
        }
    }
}
