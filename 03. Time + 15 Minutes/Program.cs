using System;

namespace _03._Time___15_Minutes
{
    class Program
    {

        static void CheckMin(int minute, int hour)
        {
            if (minute < 10)
            {
                Console.WriteLine(hour + ":0" + minute);
            }
            else
            {
                Console.WriteLine(hour + ":" + minute);
            }
        }
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 15;

            if (minute >= 60)
            {
                hour++;
                if (hour == 24)
                {
                    hour = 0;
                    minute = minute % 60;
                    CheckMin(minute,hour);
                }
                else
                {
                    minute = minute % 60;
                    CheckMin(minute,hour);
                }
            }
            else
            {
                Console.WriteLine(hour + ":" + minute);
            }
        }
    }
}
