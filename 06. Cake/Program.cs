using System;

namespace _06._Cake
{
    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();

            int area = length * width;
            int pieces = 0;

            while (comand != "STOP")
            {
                int temp = int.Parse(comand);
                pieces += temp;
                if (pieces >= area)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(area - pieces)} pieces more.");
                    break;
                }
                else
                {
                    temp = 0;
                    comand = Console.ReadLine();
                }
            }
            if (comand == "STOP")
            {
                Console.WriteLine($"{Math.Abs(area - pieces)} pieces are left.");
            }
        }
    }
}
