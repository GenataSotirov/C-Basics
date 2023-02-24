using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main()
        {
            int detergent = int.Parse(Console.ReadLine()) * 750;

            string input = Console.ReadLine();
            bool notEnough = true;
            int countDishes = 0;
            int countPots = 0;
            int count = 1;

            while (input != "End")
            {
                int dishes = int.Parse(input);
                
                if (count%3==0)
                {
                    detergent -= dishes * 15; 
                    countPots += dishes;
                    count++;
                }
                else
                {
                    countDishes += dishes;
                    detergent -= dishes * 5;
                    count++;
                }
                if (detergent<0)
                {
                    notEnough = false;
                    break;
                }
                input = Console.ReadLine();
            }
            if (notEnough)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{countDishes} dishes and {countPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
            }
        }
    }
}
