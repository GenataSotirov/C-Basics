using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double realTime = distance * timePerMeter;
            double decrease = Math.Floor(distance / 15) * 12.5;
            realTime = realTime + decrease;

            if (realTime >= record)
            {
                double differance = realTime - record;
                Console.Write("No, he failed! He was ");
                Console.Write("{0:f2}", differance);
                Console.WriteLine(" seconds slower.");
            }
            else
            {
                Console.Write("Yes, he succeeded! The new world record is ");
                Console.Write("{0:f2}", realTime);
                Console.WriteLine(" seconds.");
            }
        }
    }
}
