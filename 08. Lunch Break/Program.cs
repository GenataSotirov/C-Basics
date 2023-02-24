using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main()
        {
            string serial = Console.ReadLine();
            int timeSerial = int.Parse(Console.ReadLine());
            double restTime = int.Parse(Console.ReadLine());

            double lunch = restTime / 8;
            double nap = restTime / 4;
            double leftTime = restTime - lunch - nap;

            if (leftTime >= timeSerial)
            {
                Console.WriteLine("You have enough time to watch " + serial + " and left with " + Math.Ceiling(leftTime-timeSerial) 
                    + " minutes free time.");
            }
            else
            {
                Console.Write("You don't have enough time to watch ");
                Console.Write(serial);
                Console.Write(", you need ");
                Console.Write(Math.Ceiling(timeSerial-leftTime));
                Console.WriteLine(" more minutes.");
            }
        }
    }
}
