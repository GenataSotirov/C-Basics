using System;

namespace _07._Moving
{
    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = length * width * height;
            string comand = Console.ReadLine();
            int boxes = 0;

            while (comand != "Done")
            {
                int temp = int.Parse(comand);
                boxes += temp;
                if (boxes >= volume)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(boxes - volume)} Cubic meters more.");
                    break;
                }
                else
                {
                    comand = Console.ReadLine();
                }
                
            }
            if (comand == "Done")
            {
                Console.WriteLine($"{Math.Abs(boxes - volume)} Cubic meters left.");
            }
        }
    }
}
