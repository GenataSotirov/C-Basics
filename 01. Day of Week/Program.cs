﻿using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 7 || number < 1)
            {
                Console.WriteLine("Error");
            }
            else
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
            }
        }
    }
}