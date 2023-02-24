using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "2147483647";
            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (num < minNumber)
                {
                    minNumber = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
