using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());
            int fens = int.Parse(Console.ReadLine());
            int countA = 0;
            int countB = 0;
            int countV = 0;
            int countG = 0;

            for (int i = 1; i <= fens; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A':
                        countA++;
                        break;
                    case 'B':
                        countB++;
                        break;
                    case 'V':
                        countV++;
                        break;
                    case 'G':
                        countG++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{(double)countA/fens *100:f2}%");
            Console.WriteLine($"{(double)countB / fens * 100:f2}%");
            Console.WriteLine($"{(double)countV / fens * 100:f2}%");
            Console.WriteLine($"{(double)countG / fens * 100:f2}%");
            Console.WriteLine($"{((double)countA+countB+countV+countG) / capacity * 100:f2}%");
        }
    }
}
