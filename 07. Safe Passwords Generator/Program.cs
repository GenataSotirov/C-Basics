using System;
using System.Text;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxCount = int.Parse(Console.ReadLine());

            int codeOne = 35;
            int codeTwo = 64;

            for (int z = 1; z <= a; z++)
            {
                for (int h = 1; h <= b; h++)
                {
                    if (codeOne > 55)
                    {
                        codeOne = 35;
                    }
                    if (codeTwo > 96)
                    {
                        codeTwo = 64;
                    }
                    char first = (char)codeOne;
                    char second = (char)codeTwo;
                    Console.Write($"{first}{second}{z}{h}{second}{first}|");
                    codeOne++;
                    codeTwo++;
                    maxCount--;
                    if (maxCount == 0)
                    {
                        break;
                    }
                }
                if (maxCount == 0)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
