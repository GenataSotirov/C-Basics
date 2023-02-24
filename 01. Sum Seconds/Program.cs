using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int total = first + second + third;

            int minutes = total / 60;
            int seconds = total % 60;
            //string sec = "a";

                if (seconds < 10)
                {
                    //sec = "0" + seconds;
                    Console.WriteLine(minutes + ":0" + seconds);
                }
                else
                {
                    Console.WriteLine(minutes + ":" + seconds);
                }
        }
    }
}
